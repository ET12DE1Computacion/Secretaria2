using DominioSecretaria.Escuela;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Faltas
{
    [Table("Falta")]
    public class Falta
    {
        [ForeignKey("idCursada")]
        [Required]
        public Cursada Cursada { get; private set; }

        [ForeignKey("idTipoFalta")]
        [Required]
        public TipoFalta TipoFalta { get; set; }

        [Column("fecha", TypeName = "Date")]
        [Required]
        public DateTime Fecha { get; set; }

        [Column("justificada")]
        [Required]
        public bool Justificada { get; set; } = false;

        public Falta(Cursada cursada, TipoFalta tipoFalta)
        {
            Cursada = cursada;
            TipoFalta = tipoFalta;
            Fecha = DateTime.Now.Date;
            Justificada = false;
        }

        public Falta() { }
    }
}