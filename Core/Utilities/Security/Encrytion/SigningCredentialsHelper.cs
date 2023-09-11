﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encrytion
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securitykey)
        {
            return new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
