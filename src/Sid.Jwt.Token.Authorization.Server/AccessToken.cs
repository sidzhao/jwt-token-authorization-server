using System;
using System.Collections.Generic;
using System.Text;

namespace Sid.Jwt.Token.Authorization.Server
{
    public class AccessToken
    {
        public string scheme { get; set; }

        public string access_token { get; set; }

        public int expires_in { get; set; }
    }
}
