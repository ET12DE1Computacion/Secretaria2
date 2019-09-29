using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Escuela
{
    [Table("Seguimiento")]
    public class Seguimiento
    {
        [Key, Column("idObservacion")]
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
