using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Secretaria.Domain.Escuela
{
    public class Seguimiento
    {
        public int IdSeguimiento { get; set; }

        public Alumno Alumno { get; set; }
        
        public string Observacion { get; set; }
        
        public DateTime Fecha { get; set; }

        public Seguimiento() { }
        
        public Seguimiento(Alumno alumno, string observacion)
        {
            Alumno = alumno;
            Fecha = DateTime.Now;
        }
    }
}
