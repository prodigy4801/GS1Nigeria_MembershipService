using AutoMapper;
using MembershipPortal.api.Helpers;
using MembershipPortal.api.Helpers.RegistrationAPIService;
using MembershipPortal.api.Helpers.RegistrationAPIService.Request;
using MembershipPortal.api.Models;
using MembershipPortal.data.ExternalEntries;
using MembershipPortal.data.ExternalEntries.Models;
using MembershipPortal.service;
using MembershipPortal.service.Concrete.ExternalEntries;
using MembershipPortal.viewmodels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Authorization
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _settings;
        private readonly RegistrationAPI_Settings _regApiSettings;

        //public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> settings, IOptions<RegistrationAPI_Settings> regApiSettings)
        {
            this._next = next;
            this._settings = settings.Value;
            this._regApiSettings = regApiSettings.Value;
        }

        public async Task Invoke(HttpContext context, IUserSvc service, IJwtUtils jwtUtils, IMapper mapper, IUserValidationTokenSvc uservalidationtokenservice)
        {
            
            try
            {
                var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                if (token != null)
                {
                    var regid = jwtUtils.ValidateToken(token, this._settings.Key);
                    //get userregistrationid
                    var baseURL = this._regApiSettings.BaseUrl;
                    var endpoint = "api/v2/user/getbyregid";
                    ExternalCallModels servicerequest = new ExternalCallModels()
                    {
                        baseURL = baseURL,
                        endpoint = endpoint,
                        Token = token
                    };
                    //if (regid.istokenexpired && !regid.istokenvalid)
                    //{
                    //    var principal = jwtUtils.GetPrincipalFromExpiredToken(mainToken);
                    //    var userregid = principal.Identity?.Name;

                    //    var userRecord = await service.GetByRegistrationID(userregid, servicerequest);

                    //    if (userRecord.ReturnedObject != null && userRecord.IsSuccess)
                    //    {
                    //        var savedrefreshtoken = await uservalidationtokenservice.GetByRefreshToken(userRecord.ReturnedObject.id, refreshToken, servicerequest);
                    //        if (savedrefreshtoken != null)
                    //        {
                    //            var generateToken = jwtUtils.GenerateJWTToken(userregid);
                    //        }
                    //        context.Items["AuthenticatedUser"] = mapper.Map<AuthenticatedPayload>(userRecord.ReturnedObject);
                    //    }
                    //}
                    if (regid != null && regid.IsSuccess && regid.ReturnedObject.istokenvalid && !regid.ReturnedObject.istokenexpired)
                    {
                        var userRecord = await service.GetByRegistrationID(regid.ReturnedObject.tokenkey, servicerequest);
                        if (userRecord.ReturnedObject != null)
                        {
                            context.Items["AuthenticatedUser"] = mapper.Map<AuthenticatedPayload>(userRecord.ReturnedObject);
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }

            await _next(context);
        }
    }
}
