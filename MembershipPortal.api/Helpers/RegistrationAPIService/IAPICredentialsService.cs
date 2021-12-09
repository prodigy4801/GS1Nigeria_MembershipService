using MembershipPortal.api.Helpers.RegistrationAPIService.Request;
using MembershipPortal.api.Helpers.RegistrationAPIService.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Helpers.RegistrationAPIService
{
    public interface IAPICredentialsService
    {
        RegistrationResponse RegisterCredentials(RegistrationRequest req);
        GenerateTokenResponse GenerateToken(GenerateTokenRequest req);
        GenerateTokenResponse ValidateToken(ValidateTokenRequest req);
    }
}
