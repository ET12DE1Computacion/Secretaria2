using Microsoft.AspNetCore.Identity;
using System;

namespace Secretaria.FrontEnd.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string NombreCompleto { get; set; }
        public bool Habilitado { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIp { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedIp { get; set; }
    }
}
