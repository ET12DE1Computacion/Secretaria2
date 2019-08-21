using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Escuela
{
    [Table("Curso")]
    public class Curso
    {
        [Key,Column("idCurso")]
        public int IdCurso { get; set; }

        [Column("division")]
        public byte Division { get; set; }

        [Column("anio")]
        public byte Anio { get; set; }

        public List<Alumno> Alumnos { get; set; }

        public Curso()
        {
            Alumnos = new List<Alumno>();
        }

        public Curso(byte anio, byte division) : this()
        {
            Anio = anio;
            Division = division;
        }

        public void agregarAlumno(Alumno alumno)
        {
            Alumnos.Add(alumno);
        }

        public void sacarAlumno(Alumno alumno)
        {
            Alumnos.Remove(alumno);
        }
    }
}
