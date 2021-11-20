﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace PowerUtils.AspNetCore.Authentication.JwtBearer.Attributes
{
    public class JWTAuthentication : AuthorizeAttribute
    {
        public const string AUTHENTICATION_SCHEMES = JwtBearerDefaults.AuthenticationScheme;

        public JWTAuthentication()
        {
            AuthenticationSchemes = AUTHENTICATION_SCHEMES;
        }
    }
}