using DominioSecretaria.Util;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Faltas
{
    [Table("TipoFalta")]
    public class TipoFalta : TextoSencillo
    {
        public List<Falta> faltas { get; set; }

        public TipoFalta()
        {
            faltas = new List<Falta>();
        }
    }
}