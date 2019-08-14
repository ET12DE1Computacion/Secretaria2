using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Escuela
{
    [Table("SeguimientoAlumno")]
    public class Seguimiento
    {
        [Key]
        [Column("idSeguimiento")]
        public int IdSeguimiento { get; set; }

        [ForeignKey("idAlumno")]
        [Required]
        public Alumno Alumno { get; set; }

        [Column("observacion")]
        [StringLength(254)]
        [Required]
        public string Observacion { get; set; }


        [Column("fecha", TypeName = "Date")]
        [Required]
        public DateTime Fecha { get; set; }

        public Seguimiento() { }
        public Seguimiento(Alumno alumno, string observacion)
        {
            Alumno = alumno;
            Fecha = DateTime.Now;
        }
    }
}
