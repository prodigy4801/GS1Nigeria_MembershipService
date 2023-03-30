using MembershipPortal.data.ExternalEntries;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IGenericRegistrationCallSvc<TResponse, TRequest> where TResponse : class where TRequest : class
    {
        Task<GenericResponse<TResponse>> Save(TRequest req, ExternalCallModels apilink);
        Task<GenericResponseList<TResponse>> GetListByRegistrationID(string regID, ExternalCallModels apilink);
    }
    public class GenericRegistrationCallSvc<TResponse, TRequest> where TResponse : class where TRequest : class
    {
        public async Task<GenericResponseList<TResponse>> GetListByRegistrationID(string regID, ExternalCallModels apilink)
        {
            GenericResponseList<TResponse> response = new GenericResponseList<TResponse>()
            {
                IsSuccess = false,
                Message = string.Empty,
                ReturnedObject = null
            };

            try
            {
                var client = new RestClient(string.Format("{0}{1}{2}", apilink.baseURL, apilink.endpoint, regID));

                var restRequest = new RestRequest(Method.GET);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("Authorization", $"Bearer {apilink.Token}");
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");

                IRestResponse resp = await client.ExecuteAsync<TResponse>(restRequest);

                if (resp.StatusCode != 0 || !resp.IsSuccessful)
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        var profile = JsonConvert.DeserializeObject<IEnumerable<TResponse>>(resp.Content.ToString());
                        response.ReturnedObject = profile;
                        response.IsSuccess = true;
                        response.Message = "Successful get record.";
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
        public async Task<GenericResponse<TResponse>> Save(TRequest req, ExternalCallModels apilink)
        {
            GenericResponse<TResponse> response = new GenericResponse<TResponse>()
            {
                IsSuccess = false,
                Message = string.Empty,
                ReturnedObject = null
            };

            try
            {
                var client = new RestClient(string.Format("{0}{1}", apilink.baseURL, apilink.endpoint));

                var restRequest = new RestRequest(Method.POST);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("Authorization", $"Bearer {apilink.Token}");
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");
                restRequest.AddJsonBody(req);

                IRestResponse resp = await client.ExecuteAsync<TResponse>(restRequest);

                if (resp.StatusCode != 0 || !resp.IsSuccessful)
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        var profile = JsonConvert.DeserializeObject<GenericResponse<TResponse>>(resp.Content.ToString());
                        response.ReturnedObject = profile.ReturnedObject;
                        response.IsSuccess = profile.IsSuccess;
                        response.Message = profile.Message;
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
