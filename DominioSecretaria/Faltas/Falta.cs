using DominioSecretaria.Escuela;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Faltas
{
    //[Table("Falta")]
    [NotMapped]
    public class Falta
    {
        public int id { get; set; }
        public Alumno legajo { get; set; }
        public TipoFalta idTipoFalta { get; set; }
        public TipoAusencia idTipoAusencia { get; set; }
        public DateTime Fecha { get; set; }
        public string falta { get; set; }
        public bool Justificada { get; set; } = false;

        public Falta(Cursada cursada, TipoFalta tipoFalta)
        {

            idTipoFalta = tipoFalta;
            Fecha = DateTime.Now.Date;
            Justificada = false;
        }

        public Falta() { }
    }
}