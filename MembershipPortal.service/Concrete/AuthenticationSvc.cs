using MembershipPortal.core;
using MembershipPortal.data.ExternalEntries.Models;
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
        private readonly IUnitOfWork _uow;
        private readonly string[] _includeProps = new string[] { };

        public AuthenticationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }
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

        public async Task<GenericResponse<PasswordReset_Response>> ForgotPassword(Authentication_ForgotPassword req, string baseURL, string forgotPasswordURL)
        {
            GenericResponse<PasswordReset_Response> response = new GenericResponse<PasswordReset_Response>()
            {
                IsSuccess = false,
                Message = string.Empty,
                ReturnedObject = new PasswordReset_Response()
            };

            try
            {
                var client = new RestClient(string.Format("{0}{1}", baseURL, forgotPasswordURL));

                var restRequest = new RestRequest(Method.POST);
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.AddHeader("content-type", "application/json;application/x-www-form-urlencoded;");
                restRequest.AddJsonBody(req);

                IRestResponse resp = await client.ExecuteAsync<GenericResponse<PasswordReset_Response>>(restRequest);

                if (resp.StatusCode != 0 || !resp.IsSuccessful)
                {
                    if (!(string.IsNullOrEmpty(resp.Content.ToString())))
                    {
                        response = JsonConvert.DeserializeObject<GenericResponse<PasswordReset_Response>>(resp.Content.ToString());
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

        public async Task<GenericResponse<UserModel>> PasswordChange(string email, string currentpassword, string newpassword)
        {
            try
            {
                var password_hash = Helpers.AuthManipulationService.HashPwd(currentpassword);
                var getUserRecord = await _uow.UserRP.GetBySingleOrDefault(s => s.email == email && s.password == password_hash, _includeProps);
                if (getUserRecord == null) return new GenericResponse<UserModel> {  ReturnedObject = null, IsSuccess = false, Message = "Invalid Email and Password." };


                getUserRecord.passwordconfirm = newpassword;
                getUserRecord.password = Helpers.AuthManipulationService.HashPwd(newpassword);
                getUserRecord.updatedon = DateTime.UtcNow;
                _uow.UserRP.Update(getUserRecord);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<UserModel> { ReturnedObject = getUserRecord, IsSuccess = true, Message = "Successfully Changed Password. Relogin to your Account." };
                }
                return new GenericResponse<UserModel> { ReturnedObject = null, IsSuccess = false, Message = "Failed to change your password." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<UserModel> { ReturnedObject = null, IsSuccess = false, Message = ex.Message };
            }
        }
    }
}
