using MembershipPortal.data.ExternalEntries;
using MembershipPortal.data.ExternalEntries.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service.Concrete.ExternalEntries
{
    public interface IUserValidationTokenSvc
    {
        Task<GenericResponse<UserValidationTokenModel>> GetByRefreshToken(int userid, string refreshToken, ExternalCallModels request);
    }
    public class UserValidationTokenSvc : IUserValidationTokenSvc
    {
        public async Task<GenericResponse<UserValidationTokenModel>> GetByRefreshToken(int userid, string refreshToken, ExternalCallModels request)
        {
            GenericResponse<UserValidationTokenModel> response = new GenericResponse<UserValidationTokenModel>()
            {
                IsSuccess = false,
                Message = string.Empty,
                ReturnedObject = null
            };

            try
            {
                var client = new RestClient(string.Format("{0}{1}", request.baseURL, request.endpoint));

                var restRequest = new RestRequest(Method.POST);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("Authorization", $"Bearer {request.Token}");
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");
                restRequest.AddParameter("userid", userid);
                restRequest.AddParameter("refreshToken", refreshToken);

                IRestResponse resp = await client.ExecuteAsync<GenericResponse<UserValidationTokenModel>>(restRequest);

                if (resp.StatusCode != 0 || !resp.IsSuccessful)
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        response = JsonConvert.DeserializeObject<GenericResponse<UserValidationTokenModel>>(resp.Content.ToString());
                    }
                    else
                    {
                        response.Message = resp.StatusDescription;
                    }
                }
                else
                {
                    response.Message = "Internal Server Error. No Connection between the Service and the Application";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
