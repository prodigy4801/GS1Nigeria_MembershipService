using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembershipPortal.api.Helpers.RegistrationAPIService.Request;
using MembershipPortal.api.Helpers.RegistrationAPIService.Response;
using RestSharp;
using Microsoft.Extensions.Options;
using MembershipPortal.api.Models;
using Newtonsoft.Json;

namespace MembershipPortal.api.Helpers.RegistrationAPIService
{
    public class APICredentialsService : IAPICredentialsService
    {
        private readonly RegistrationAPI_Settings _registrationAPI;

        public APICredentialsService(IOptions<RegistrationAPI_Settings> registrationAPI)
        {
            this._registrationAPI = registrationAPI.Value;
        }

        public RegistrationResponse RegisterCredentials(RegistrationRequest req)
        {
            RegistrationResponse response = new RegistrationResponse();
            var baseURL = this._registrationAPI.BaseUrl;
            var registrationURL = this._registrationAPI.RegisterAPI;

            try
            {
                var regRequest = new RegistrationRequest()
                {
                    email = req.email,
                    full_name = req.full_name,
                    password = req.password,
                    username = req.username,
                };
                var client = new RestClient(string.Format("{0}{1}", baseURL, registrationURL));

                var restRequest = new RestRequest(Method.POST);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");
                restRequest.AddJsonBody(regRequest);

                IRestResponse resp = client.Execute<RegistrationRequest>(restRequest);

                if (!(string.IsNullOrEmpty(resp.ToString())))
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        response = JsonConvert.DeserializeObject<RegistrationResponse>(resp.Content.ToString());
                    }
                    else
                    {
                        response.message = resp.StatusDescription;
                    }
                }
                else
                {
                    response.data = null;
                    response.isSuccess = false;
                    response.message = "Internal Server Error. No Connection between the Service and the Application";
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return response;
        }

        public GenerateTokenResponse GenerateToken(GenerateTokenRequest req)
        {
            GenerateTokenResponse response = new GenerateTokenResponse();
            var baseURL = this._registrationAPI.BaseUrl;
            var token = this._registrationAPI.TokenGenerator;

            try
            {
                var tokenRequest = new GenerateTokenRequest()
                {
                    username = req.username,
                    password = req.password
                };
                var client = new RestClient(string.Format("{0}{1}", baseURL, token));

                var restRequest = new RestRequest(Method.POST);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");
                restRequest.AddJsonBody(tokenRequest);

                IRestResponse resp = client.Execute<GenerateTokenResponse>(restRequest);

                if (!(string.IsNullOrEmpty(resp.ToString())))
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        response = JsonConvert.DeserializeObject<GenerateTokenResponse>(resp.Content.ToString());
                    }
                }
            }
            catch (Exception e)
            {

            }
            return response;
        }

        public GenerateTokenResponse ValidateToken(ValidateTokenRequest req)
        {
            GenerateTokenResponse response = new GenerateTokenResponse();
            var baseURL = this._registrationAPI.BaseUrl;
            var token = this._registrationAPI.TokenValidator;

            try
            {
                var tokenRequest = new ValidateTokenRequest()
                {
                    token = req.token,
                    securityKey = req.securityKey
                };
                var client = new RestClient(string.Format("{0}{1}", baseURL, token));

                var restRequest = new RestRequest(Method.POST);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");
                restRequest.AddJsonBody(tokenRequest);

                IRestResponse resp = client.Execute<GenerateTokenResponse>(restRequest);

                if (!(string.IsNullOrEmpty(resp.ToString())))
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        response = JsonConvert.DeserializeObject<GenerateTokenResponse>(resp.Content.ToString());
                    }
                }
            }
            catch (Exception e)
            {

            }
            return response;
        }
    }
}
