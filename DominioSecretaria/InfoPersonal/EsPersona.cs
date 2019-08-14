using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.InfoPersonal
{
    public abstract class EsPersona
    {
        [Key]
        [Column("idPersona")]
        [ForeignKey("Persona")]
        public int Id { get; set; }

        public Persona Persona { get; set; }

        public EsPersona() { }
        public EsPersona(Persona persona)
        {
            this.Persona = persona;
        }
        [NotMapped]
        public string Nombre => Persona.Nombre;

        [NotMapped]
        public string Apellido => Persona.Apellido;

        [NotMapped]
        public Domicilio Domicilio => Persona.Domicilio;

        [NotMapped]
        public string Mail => Persona.Mail;

    }
}
