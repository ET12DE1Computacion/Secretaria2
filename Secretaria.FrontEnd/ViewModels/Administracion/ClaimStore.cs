using System.Collections.Generic;
using System.Security.Claims;

namespace Secretaria.FrontEnd.ViewModels.Administracion
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
            new Claim("Crear Usuarios", "Crear Usuarios"),
            new Claim("Editar Usuarios", "Editar Usuarios"),
            new Claim("Borrar Usuarios", "Borrar Usuarios"),
            new Claim("Crear Roles", "Crear Roles"),
            new Claim("Editar Roles", "Editar Roles"),
            new Claim("Borrar Roles", "Borrar Roles")
        };
    }
}
