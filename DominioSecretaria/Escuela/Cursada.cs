using DominioSecretaria.Faltas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Escuela
{
    public class Cursada
    {
        public int idCursada { get; set; }

        public Alumno Alumno { get; set; }

        public Curso Curso { get; set; }

        public short CicloLectivo { get; set; }

        public DateTime Fecha { get; set; }

        public List<Falta> Faltas { get; set; }
    }
}
