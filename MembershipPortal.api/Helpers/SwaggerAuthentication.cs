using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.api.Helpers
{
    public class SwaggerAuthentication
    {
        private readonly RequestDelegate _next;

        public SwaggerAuthentication(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/swagger"))
            {
                string authHeader = context.Request.Headers["Authorization"];
                if (authHeader != null && authHeader.StartsWith("Basic "))
                {
                    var header = AuthenticationHeaderValue.Parse(authHeader);
                    var inBytes = Convert.FromBase64String(header.Parameter);
                    var credentials = Encoding.UTF8.GetString(inBytes).Split(':');
                    var username = credentials[0];
                    var password = credentials[1];

                    //validate credential
                    if (username.Equals("membershipswaggerusername") && password.Equals("membershipswaggerpassword"))
                    {
                        await this._next.Invoke(context).ConfigureAwait(false);
                        return;
                    }
                }

                context.Response.Headers["WWW-Authenticate"] = "Basic ";
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            }
            else
            {
                await this._next.Invoke(context).ConfigureAwait(false);
            }
        }
    }
}
