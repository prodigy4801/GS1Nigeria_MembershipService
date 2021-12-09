using MembershipPortal.api.Helpers.RegistrationAPIService;
using MembershipPortal.api.Helpers.RegistrationAPIService.Request;
using MembershipPortal.api.Models;
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
        private readonly RegistrationAPI_Settings _regApiSettings;

        //public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        public JwtMiddleware(RequestDelegate next, IOptions<RegistrationAPI_Settings> regApiSettings)
        {
            this._next = next;
            this._regApiSettings = regApiSettings.Value;
        }

        public async Task Invoke(HttpContext context, IAPICredentialsService service)
        {
            
            try
            {
                var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                ValidateTokenRequest request = new ValidateTokenRequest
                {
                     token = token,
                     securityKey = this._regApiSettings.Key
                };
                var authenticatedUser = service.ValidateToken(request);
                if (authenticatedUser != null)
                {
                    //var model = 
                    //var obj = _mapper.Map<APICredentialsVM>(model);
                    context.Items["AuthenticatedUser"] = authenticatedUser;
                }
            }
            catch (Exception e)
            {

            }

            await _next(context);
        }
    }
}
