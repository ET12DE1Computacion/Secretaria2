﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Secretaria.FrontEnd.Identity
{
    public static class IdentityExtension
    {
        public static string NombreCompleto(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("NombreCompleto");
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string PathImagen(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("PathImagen");
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}
