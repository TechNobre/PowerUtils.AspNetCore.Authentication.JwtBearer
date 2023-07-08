using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace PowerUtils.AspNetCore.Authentication.JwtBearer.Attributes
{
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary. The package will be completely removed after 2024/01/08.")]
    public class JWTAuthentication : AuthorizeAttribute
    {
        public const string AUTHENTICATION_SCHEMES = JwtBearerDefaults.AuthenticationScheme;

        public JWTAuthentication()
            => AuthenticationSchemes = AUTHENTICATION_SCHEMES;
    }
}
