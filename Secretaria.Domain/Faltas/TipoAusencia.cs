using Secretaria.Domain.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secretaria.Domain.Faltas
{
    public class TipoAusencia : TextoSencillo
    {
        public float ValorFalta { get; set; }

        public List<Falta> Faltas { get; set; }

        public TipoAusencia() 
        {
            Faltas = new List<Falta>();
        }
    }
}
