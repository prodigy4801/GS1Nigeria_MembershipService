using MembershipPortal.data.ExternalEntries.Models;
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
        Task<GenericResponse<PasswordReset_Response>> ForgotPassword(Authentication_ForgotPassword req, string baseURL, string forgotPasswordURL);
        Task<GenericResponse<UserModel>> PasswordChange(string email, string previouspassword, string newpassword);
    }
}
