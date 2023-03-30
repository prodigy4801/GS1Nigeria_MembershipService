using MembershipPortal.core;
using MembershipPortal.service.Helpers;
using MembershipPortal.service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IStatisticsService
    {
        Task<GenericResponse<CompanyRenewalAccumulationModel>> RenewalAccumulation(string registrationid);
    }

    public class StatisticsService : IStatisticsService
    {
        private readonly IUnitOfWork _uow;
        private readonly ApplicationDBContext _context;
        private string[] _includecompany = { "CompanySectorCategories", "CompanySectorTypes", "Countries" };
        public StatisticsService(IUnitOfWork uow, ApplicationDBContext context)
        {
            _uow = uow;
            _context = context;
        }
        public async Task<GenericResponse<CompanyRenewalAccumulationModel>> RenewalAccumulation(string registrationid)
        {
            var info = new CompanyRenewalAccumulationModel();
            var renewalAcc = new List<RenewalAccumulationModel>();

            DateTime FeeIncrementDate = new DateTime(2022, 07, 01);

            try
            {
                var getCompanyinfoByRegID = await _uow.CompanyRP.GetBySingleOrDefault(x => x.registrationid == registrationid, _includecompany);
                info.CompanyName = getCompanyinfoByRegID.companyname;

                var gtinRequestInfo = await (from gr in _context.GTINRequests
                                            where gr.registrationid == registrationid && gr.isgcpassigned && gr.requesttype == "initial"
                                             select new GCPRequestCompact()
                                            {
                                                 ID = gr.id,
                                                DateOfIssuance = Convert.ToDateTime(gr.assigneddate),
                                                NumberOfGtins = gr.gtincount,
                                                RegistrationID = gr.registrationid
                                            }).OrderByDescending(x => x.ID).FirstAsync();
                info.FirstInsuanceDate = gtinRequestInfo.DateOfIssuance.ToShortDateString();
                info.FirstIssuedGtin = gtinRequestInfo.NumberOfGtins;

                GCPRequestCompact firstRequest = gtinRequestInfo;
                var additionalRequestInfo = await (from gr in _context.GTINRequests
                                       where gr.registrationid == registrationid && gr.isgcpassigned == true && gr.requesttype == "additional"
                                       select new GCPRequestCompact()
                                       {
                                           DateOfIssuance = Convert.ToDateTime(gr.assigneddate),
                                           NumberOfGtins = gr.gtincount,
                                           RegistrationID = gr.registrationid
                                       }).ToListAsync();
                additionalRequestInfo.Insert(0, firstRequest);

                var startDate = new DateTime(firstRequest.DateOfIssuance.Year, firstRequest.DateOfIssuance.Month, 1);
                //var endDate = new DateTime(firstRequest.DateOfIssuance.AddYears(1).Year, firstRequest.DateOfIssuance.AddYears(1).Month, 1);
                //var endDate = new DateTime(firstRequest.DateOfIssuance.AddYears(1).Year, firstRequest.DateOfIssuance.AddYears(1).Month, 1);
                var endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                double amountToPay = 0.0;
                int totalNumberOfGTINs = 0;
                int counter = 1;
                while(startDate <= endDate)
                {
                    var accumulatedRenewal = new RenewalAccumulationModel();
                    accumulatedRenewal.YearCount = counter;
                    accumulatedRenewal.RenewalYear = startDate.ToShortDateString();

                    var totalGTINs = 0;
                    foreach(var request in additionalRequestInfo)
                    {
                        if(new DateTime(request.DateOfIssuance.Year, request.DateOfIssuance.Month, 1) <= startDate)
                        {
                            totalGTINs = totalGTINs + request.NumberOfGtins;
                            accumulatedRenewal.GtinCount = request.NumberOfGtins;
                            accumulatedRenewal.AccumulatedGtin = totalGTINs;
                        }
                    }

                    decimal gtinPrice = 0;
                    gtinPrice = startDate >= FeeIncrementDate ? AdministrativeService.GetNewRenewalAmount(totalGTINs) : AdministrativeService.GetRenewalAmount(totalGTINs);
                    accumulatedRenewal.Amount = gtinPrice;

                    amountToPay = amountToPay + Convert.ToDouble(gtinPrice);
                    accumulatedRenewal.AccumulatedAmount = amountToPay;
                    totalNumberOfGTINs = totalGTINs;
                    startDate = startDate.AddYears(1);
                    renewalAcc.Add(accumulatedRenewal);
                    counter = counter + 1;
                }
                info.AccumulatedInfo = renewalAcc;

                return new GenericResponse<CompanyRenewalAccumulationModel> { IsSuccess = true, Message = "Successful Statistics Retrieval", ReturnedObject = info };
            }
            catch (Exception ex)
            {
                return new GenericResponse<CompanyRenewalAccumulationModel> { IsSuccess = false, Message = ex.Message, ReturnedObject = null };
            }
        }
    }
}
