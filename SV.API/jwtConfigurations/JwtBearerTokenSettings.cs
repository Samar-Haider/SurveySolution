﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SV.API.jwtConfigurations
{
    public class JwtBearerTokenSettings
    {
        public string SecretKey { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int ExpiryTimeInMinute { get; set; }

        public int RefreshTokenExpiryTimeInMinute { get; set; }
    }
}
