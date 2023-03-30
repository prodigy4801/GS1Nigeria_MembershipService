
using MembershipPortal.data.ExternalEntries;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service.Concrete.ExternalEntries
{
    public interface IGenericExternalAPICallsSvc<T> where T : class
    {
        Task<GenericResponse<T>> GetByID(int id, ExternalCallModels request);
        Task<GenericResponse<T>> GetByRegistrationID(string regID, ExternalCallModels request);
        Task<GenericResponseList<T>> GetListByRegistrationID(string regID, ExternalCallModels request);
        Task<GenericResponse<T>> Save(T model, ExternalCallModels request);
    }
    public class GenericExternalAPICallsSvc<T> : IGenericExternalAPICallsSvc<T> where T : class
    {
        public async Task<GenericResponse<T>> GetByID(int id, ExternalCallModels request)
        {
            GenericResponse<T> response = new GenericResponse<T>()
            {
                IsSuccess = false,
                Message = string.Empty,
                ReturnedObject = null
            };

            try
            {
                var client = new RestClient(string.Format("{0}{1}{2}", request.baseURL, request.endpoint, id));

                var restRequest = new RestRequest(Method.GET);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("Authorization", $"Bearer {request.Token}");
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");

                IRestResponse resp = await client.ExecuteAsync<T>(restRequest);

                if (resp.StatusCode != 0 || !resp.IsSuccessful)
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        var profile = JsonConvert.DeserializeObject<T>(resp.Content.ToString());
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


        public async Task<GenericResponse<T>> GetByRegistrationID(string regID, ExternalCallModels request)
        {
            GenericResponse<T> response = new GenericResponse<T>()
            {
                IsSuccess = false,
                Message = string.Empty,
                ReturnedObject = null
            };

            try
            {
                var client = new RestClient(string.Format("{0}{1}", request.baseURL, request.endpoint));

                var restRequest = new RestRequest(Method.GET);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("Authorization", $"Bearer {request.Token}");
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");
                //restRequest.AddQueryParameter("regid", regID);
                restRequest.AddParameter("regid", regID);

                IRestResponse resp = await client.ExecuteAsync<T>(restRequest);

                if (resp.StatusCode != 0 || !resp.IsSuccessful)
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        var profile = JsonConvert.DeserializeObject<T>(resp.Content.ToString());
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

        public async Task<GenericResponseList<T>> GetListByRegistrationID(string regID, ExternalCallModels request)
        {
            GenericResponseList<T> response = new GenericResponseList<T>()
            {
                IsSuccess = false,
                Message = string.Empty,
                ReturnedObject = null
            };

            try
            {
                var client = new RestClient(string.Format("{0}{1}{2}", request.baseURL, request.endpoint, regID));

                var restRequest = new RestRequest(Method.GET);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("Authorization", $"Bearer {request.Token}");
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");

                IRestResponse resp = await client.ExecuteAsync<T>(restRequest);

                if (resp.StatusCode != 0 || !resp.IsSuccessful)
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        var profile = JsonConvert.DeserializeObject<IEnumerable<T>>(resp.Content.ToString());
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

        public async Task<GenericResponse<T>> Save(T model, ExternalCallModels request)
        {
            GenericResponse<T> response = new GenericResponse<T>()
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
                restRequest.AddJsonBody(model);

                IRestResponse resp = await client.ExecuteAsync<T>(restRequest);

                if (resp.StatusCode != 0 || !resp.IsSuccessful)
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        var profile = JsonConvert.DeserializeObject<GenericResponse<T>>(resp.Content.ToString());
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
