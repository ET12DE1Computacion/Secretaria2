using DominioSecretaria.Util;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.InfoPersonal
{
    [Table("TipoDocumento")]
    public class TipoDocumento: TextoSencillo
    {
    }
}
