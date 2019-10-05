using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secretaria.BackEnd.ViewModel
{
    public class CursadaViewModel
    {
        public short cicloElectivo { get; set; }
        public byte anio { get; set; }
        public byte division { get; set; }
        public string turno { get;set; }
        public string especialidad { get; set; }
    }
}
