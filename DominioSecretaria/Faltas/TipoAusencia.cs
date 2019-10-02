using System;
using System.Collections.Generic;
using System.Text;

namespace DominioSecretaria.Faltas
{
    public class TipoAusencia
    {
        public int idTipoAusencia { get; set; }
        public string tipoAusencia { get; set; }
        public float falta { get; set; }

        public TipoAusencia() { }
    }
}
