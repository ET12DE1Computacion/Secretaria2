using Secretaria.Domain.Util;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Secretaria.Domain.Faltas
{
    public class TipoFalta : TextoSencillo
    {
        public List<Falta> Faltas { get; set; }

        public List<AsistenciaCurso> AsistenciaCurso { get; set; }

        public TipoFalta()
        {
            Faltas = new List<Falta>();

            AsistenciaCurso = new List<AsistenciaCurso>();
        }
    }
}