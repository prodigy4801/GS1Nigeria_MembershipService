using MembershipPortal.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IAuthenticationSvc
    {
        Task<GenericResponse<AuthenticatedPayload>> Login(LoginVM req, string baseURL, string loginURL);
    }
}
