using AutoMapper;
using MembershipPortal.data;
using MembershipPortal.viewmodels;
using MembershipPortal.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data.ExternalEntries.Models;
using MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend;

namespace MembershipPortal.configurations
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<BrandInformationVM, BrandInformation>().ReverseMap();
            CreateMap<BrandInformationVM_Create, BrandInformation>().ReverseMap();
            CreateMap<BrandInformationVM_Update, BrandInformation>().ReverseMap();

            CreateMap<BrickCategoryVM, BrickCategory>().ReverseMap();
            CreateMap<BrickCategoryVM_CRU, BrickCategory>().ReverseMap();

            CreateMap<ExternalUnifiedModelVM, ExternalUnifiedModel>().ReverseMap();
            CreateMap<ExternalUnifiedModelVM_CRU, ExternalUnifiedModel>().ReverseMap();

            CreateMap<GCPInformationVM, GCPInformation>().ReverseMap();
            CreateMap<GCPInformationVM_Create, GCPInformation>().ReverseMap();
            CreateMap<GCPInformationVM_Update, GCPInformation>().ReverseMap();

            CreateMap<GLNInformationVM, GLNInformation>().ReverseMap();
            CreateMap<GLNInformationVM_Create, GLNInformation>().ReverseMap();

            CreateMap<GTINInformationVM, GTINInformation>().ReverseMap();
            CreateMap<GTINInformationVM_Create, GTINInformation>().ReverseMap();

            CreateMap<GTINRequestVM, GTINRequest>().ReverseMap();
            CreateMap<GTINRequestVM_Create, GTINRequest>().ReverseMap();

            CreateMap<ImageBankVM, ImageBank>().ReverseMap();
            CreateMap<ImageBankVM_create, ImageBank>().ReverseMap();
            CreateMap<ImageBankVM_update, ImageBank>().ReverseMap();

            CreateMap<ImageRequestVM, ImageRequest>().ReverseMap();

            CreateMap<ImageBankUsageVM, ImageBankUsage>().ReverseMap();

            CreateMap<ITFInformationVM, ITFInformation>().ReverseMap();
            CreateMap<ITFInformationVM_Create, ITFInformation>().ReverseMap();

            CreateMap<NetContentVM, NetContent>().ReverseMap();
            CreateMap<NetContentVM_CRU, NetContent>().ReverseMap();

            CreateMap<PackageLevelVM, PackageLevel>().ReverseMap();
            CreateMap<PackageLevelVM_CRU, PackageLevel>().ReverseMap();

            CreateMap<PackagingTypeVM, PackagingType>().ReverseMap();
            CreateMap<PackagingTypeVM_CRU, PackagingType>().ReverseMap();

            CreateMap<PharmaceuticalInformationVM, PharmaceuticalInformation>().ReverseMap();
            CreateMap<PharmaceuticalInformationVM_Create, PharmaceuticalInformation>().ReverseMap();

            CreateMap<ProductVM, Product>().ReverseMap();
            CreateMap<ProductVM_Create, Product>().ReverseMap();

            CreateMap<ProductTargetMarketVM, ProductTargetMarket>().ReverseMap();
            CreateMap<ProductTargetMarketVM_Create, ProductTargetMarket>().ReverseMap();

            CreateMap<TargetMarketVM, TargetMarket>().ReverseMap();
            CreateMap<TargetMarketVM_CRU, TargetMarket>().ReverseMap();


            CreateMap<AuthenticatedPayload, UserModel>().ReverseMap();
            CreateMap<CompanyVM, Company>().ReverseMap();
            CreateMap<CompanyVM_auth, Company>().ReverseMap();
            CreateMap<GTINFeeVM, GTINFee>().ReverseMap();
            CreateMap<ImageRequestVM, ImageRequestModel>().ReverseMap();
            CreateMap<RoleVM, RoleModel>().ReverseMap();
        }
    }
}
