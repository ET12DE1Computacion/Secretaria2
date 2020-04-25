using System.ComponentModel.DataAnnotations;

namespace Secretaria.FrontEnd.ViewModels.Administracion
{
    public class CrearUsuarioViewModel
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Contraseña")]
        [Compare("Contrasenia", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden")]
        public string ConfirmarContrasenia { get; set; }
    }
}
