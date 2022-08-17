using MembershipPortal.viewmodels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service.Concrete
{
    public class AuthenticationSvc : IAuthenticationSvc
    {
        public async Task<GenericResponse<AuthenticatedPayload>> Login(LoginVM req, string baseURL, string loginURL)
        {
            GenericResponse<AuthenticatedPayload> response = new GenericResponse<AuthenticatedPayload>()
            {
                IsSuccess = false,
                Message = string.Empty,
                ReturnedObject = null
            };
            
            try
            {
                var client = new RestClient(string.Format("{0}{1}", baseURL, loginURL));

                var restRequest = new RestRequest(Method.POST);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");
                restRequest.AddJsonBody(req);

                IRestResponse resp = await client.ExecuteAsync<GenericResponse<AuthenticatedPayload>>(restRequest);

                if (resp.StatusCode != 0 || !resp.IsSuccessful)
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        response = JsonConvert.DeserializeObject<GenericResponse<AuthenticatedPayload>>(resp.Content.ToString());
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
