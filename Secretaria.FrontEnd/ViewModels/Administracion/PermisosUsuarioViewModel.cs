using System.Collections.Generic;

namespace Secretaria.FrontEnd.ViewModels.Administracion
{
    public class PermisosUsuarioViewModel
    {
        public PermisosUsuarioViewModel()
        {
            Cliams = new List<UserClaim>();
        }

        public string UserId { get; set; }
        public List<UserClaim> Cliams { get; set; }
    }
}
