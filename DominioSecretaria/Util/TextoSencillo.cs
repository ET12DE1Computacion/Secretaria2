using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Util
{
    public abstract class TextoSencillo
    {
        [Key]
        public byte Id { get; set; }
        [Required]
        public string Cadena {get; set;}
    }
}
