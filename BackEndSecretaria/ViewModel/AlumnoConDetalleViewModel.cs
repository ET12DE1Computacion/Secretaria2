using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndSecretaria.ViewModel
{
    public class AlumnoConDetalleViewModel
    {
        public int legajo { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int libro { get; set; }
        public int folio { get; set; }
        public byte anio { get; set; }
        public byte division { get; set; }
        public string tipoDocumento { get; set; }
        public int nroDocumento { get; set; }
        public DateTime nacimiento { get; set; }
        public long? telefono1 { get; set; }
        public long? telefono2 { get; set; }
        public string mail { get; set; }
        public string nacionalidad { get; set; }
        public string dominio { get; set; }
        public string calle { get; set; }
        public int? altura { get; set; }
        public byte? piso { get; set; }
        public string departamento { get; set; }
        public string codigoPostal { get; set; }
        public string observacionDomicilio { get; set; }
        public string localidad { get; set; }
    }
}
