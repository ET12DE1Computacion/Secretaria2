using DominioSecretaria.Util;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Faltas
{
    [Table("TipoFalta")]
    public class TipoFalta: TextoSencillo
    {
    }
}