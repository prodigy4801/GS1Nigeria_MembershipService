using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembershipPortal.data.ExternalEntries.Models;
using MembershipPortal.viewmodels;
using MembershipPortal.api.Models;

namespace MembershipPortal.api.Authorization
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;

            // authorization
            var user = (AuthenticatedPayload)context.HttpContext.Items["AuthenticatedUser"];
            if (user == null)
                context.Result = new JsonResult(new CustomErrorHandler { IsSuccess = false, StatusCode = 0, Message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }
    }
}
