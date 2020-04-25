using Secretaria.Domain.Faltas;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Secretaria.Domain.Escuela
{
    public class Curso
    {
        public int IdCurso { get; set; }

        public byte Division { get; set; }

        public byte Anio { get; set; }
        
        public List<Alumno> Alumnos { get; set; }

        public List<AsistenciaCurso> AsistenciaCurso { get; set; }

        public Curso()
        {
            Alumnos = new List<Alumno>();
            AsistenciaCurso = new List<AsistenciaCurso>();
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
