﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Escuela
{
    [Table("Cursada")]
    public class Cursada
    {
        [Key,Column("idCursada")]
        public int IdCursada { get; set; }

        [ForeignKey("legajo"),Required]
        public Alumno Alumno { get; set; }

        [ForeignKey("idCurso"),Required]
        public Curso Curso { get; set; }

        [Column("cicloLectivo")]
        public short CicloLectivo { get; set; }

        [Column("fecha", TypeName = "Date"),Required]
        public DateTime Fecha { get; set; }

        public virtual List<Faltas.Falta> Faltas {get; set;}
    }
}
