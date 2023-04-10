using MembershipPortal.api.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.api.Helpers
{
    public interface IJwtUtils
    {
        public ServiceResponse<string> GenerateJWTToken(JWTTokenValueModel jwtToken);
        public RefreshToken GenerateRefreshToken(string ipAddress);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
        public ServiceResponse<TokenValidationResponse> ValidateToken(string token, string authKey);
    }

    public class JwtUtils : IJwtUtils
    {
        private readonly AppSettings _appSettings;

        public JwtUtils(IOptions<AppSettings> appSettings)
        {
            this._appSettings = appSettings.Value;
        }

        public ServiceResponse<string> GenerateJWTToken(JWTTokenValueModel jwtToken)
        {
            if (jwtToken == null || string.IsNullOrEmpty(jwtToken.email) || string.IsNullOrEmpty(jwtToken.registrationID))
            {
                return new ServiceResponse<string> { IsSuccess = false, Message = "Authenticatication Key cannot be captured.", ReturnedObject = null };
            }
            string companyNameString = jwtToken.companyname == null ? string.Empty : jwtToken.companyname;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(this._appSettings.Key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, jwtToken.registrationID),
                    new Claim(ClaimTypes.Email, jwtToken.email),
                    new Claim("companyName", companyNameString)
                }),
                Expires = DateTime.UtcNow.AddDays(this._appSettings.AccessTokenExpiration_Days),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            if (token == null) return new ServiceResponse<string> { IsSuccess = false, Message = "Cannot Create a Token from it Source Descriptor.", ReturnedObject = null };
            //var refreshToken = GenerateRefreshToken();
            return new ServiceResponse<string>
            {
                IsSuccess = true,
                Message = "Successfully Generated Token",
                ReturnedObject = tokenHandler.WriteToken(token)
            };
        }

        public RefreshToken GenerateRefreshToken(string ipAddress)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[32];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                return new RefreshToken
                {
                    Token = Convert.ToBase64String(randomBytes),
                    Expires = DateTime.UtcNow.AddDays(365),
                    Created = DateTime.UtcNow,
                    CreatedByIp = ipAddress
                };
            }
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var Key = Encoding.UTF8.GetBytes(this._appSettings.Key);

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Key),
                ClockSkew = TimeSpan.Zero
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            JwtSecurityToken jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }


            return principal;
        }

        public ServiceResponse<TokenValidationResponse> ValidateToken(string token, string authKey)
        {
            if (string.IsNullOrEmpty(token)) return new ServiceResponse<TokenValidationResponse> { IsSuccess = false, Message = "Failed to retrieve Token.", ReturnedObject = null };
            if (string.IsNullOrEmpty(authKey)) return new ServiceResponse<TokenValidationResponse> { IsSuccess = false, Message = "Authenticatication Key cannot be captured.", ReturnedObject = null };

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(authKey);

            try
            {
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _appSettings.Issuer,
                    ValidAudience = _appSettings.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ClockSkew = TimeSpan.Zero
                };

                var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
                if (principal == null) return new ServiceResponse<TokenValidationResponse> { IsSuccess = false, Message = "Failed validating Token Handler.", ReturnedObject = null };

                JwtSecurityToken jwtToken = securityToken as JwtSecurityToken;
                if (jwtToken == null || !jwtToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                {
                    return new ServiceResponse<TokenValidationResponse> { IsSuccess = false, Message = "Invalid Token.", ReturnedObject = null };
                }

                if (jwtToken.ValidFrom > DateTime.UtcNow)
                {
                    return new ServiceResponse<TokenValidationResponse> { 
                        IsSuccess = false, 
                        Message = "Authentication Key validation date in invalid.",
                        ReturnedObject = new TokenValidationResponse
                        {
                            istokenexpired = false,
                            istokenvalid = false,
                            message = "Authentication Key validation date in invalid.",
                            tokenkey = string.Empty
                        },
                    };
                }

                if (jwtToken.ValidTo < DateTime.UtcNow)
                {
                    return new ServiceResponse<TokenValidationResponse>
                    {
                        IsSuccess = false,
                        Message = "Authentication Key has expired.",
                        ReturnedObject = new TokenValidationResponse
                        {
                            istokenexpired = true,
                            istokenvalid = false,
                            message = "Authentication Key has expired.",
                            tokenkey = string.Empty

                        },
                    };
                }

                var tokenKey = jwtToken.Claims.First(x => x.Type == "unique_name").Value;
                return new ServiceResponse<TokenValidationResponse>
                {
                    IsSuccess = true,
                    Message = "Successful Authentication!!!",
                    ReturnedObject = new TokenValidationResponse
                    {
                        istokenexpired = false,
                        istokenvalid = true,
                        message = "Successful Authentication!!!",
                        tokenkey = tokenKey

                    },
                };
                //return new TokenValidationResponse { istokenvalid = true, istokenexpired = false, message = "Successful Authentication!!!", tokenkey = tokenKey };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<TokenValidationResponse>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ReturnedObject = new TokenValidationResponse
                    {
                        istokenexpired = true,
                        istokenvalid = true,
                        message = ex.Message,
                        tokenkey = string.Empty

                    },
                };
            }
        }
    }
}
