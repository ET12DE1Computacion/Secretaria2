using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Secretaria.Domain.Util
{
    public abstract class TextoSencillo
    {
        public byte Id { get; set; }
        public string Cadena {get; set;}
    }
}
