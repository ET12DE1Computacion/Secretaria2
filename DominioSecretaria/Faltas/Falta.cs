using DominioSecretaria.Escuela;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Faltas
{
    public class Falta
    {
        public int idFalta { get; set; }

        public Alumno alumno { get; set; }

        public TipoFalta idTipoFalta { get; set; }

        public TipoAusencia idTipoAusencia { get; set; }

        public DateTime fecha { get; set; }

        public float falta { get; set; }

        public bool Justificada { get; set; } = false;

        public Falta(Cursada cursada, TipoFalta tipoFalta)
        {

            idTipoFalta = tipoFalta;
            fecha = DateTime.Now.Date;
            Justificada = false;
        }

        public Falta() { }
    }
}