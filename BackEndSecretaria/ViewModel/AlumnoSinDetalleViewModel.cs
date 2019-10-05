using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secretaria.BackEnd.ViewModel
{
    public class AlumnoSinDetalleViewModel
    {
        public int legajo { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int libro { get; set; }
        public int folio { get; set; }
        public byte anio { get; set; }
        public byte division { get; set; }
        public int NumeroDocumento { get; set; }
    }
}
