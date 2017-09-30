using System;
using Microsoft.IdentityModel.Tokens;

namespace Sid.Jwt.Token.Authorization.Server
{
    public class JwtTokenAuthorizationServerOptions
    {
        /// <summary>
        /// Default path is /token
        /// </summary>
        public string Path { get; set; } = "/token";

        public string Subject { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }

        public TimeSpan Expiration { get; set; } = TimeSpan.FromMinutes(5);

        public SigningCredentials SigningCredentials { get; set; }
    }
}
