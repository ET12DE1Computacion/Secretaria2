using DominioSecretaria.Escuela;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Faltas
{
    public class Falta
    {
        public int IdFalta { get; set; }

        public Alumno Alumno { get; set; }

        public TipoFalta TipoFalta { get; set; }

        public TipoAusencia TipoAusencia { get; set; }

        public Cursada Cursada { get; set; }

        public DateTime Fecha { get; set; }

        public float ValorFalta { get; set; }

        public bool Justificada { get; set; } = false;

        public Falta()
        { 

        }
    }
}