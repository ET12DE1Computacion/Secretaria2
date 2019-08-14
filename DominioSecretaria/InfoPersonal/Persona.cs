using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DominioSecretaria.InfoPersonal
{
    [Table("Persona")]
    public class Persona
    {
        [Column("idPersona")]
        [Key]
        public int IdPersona { get; set; }

        [Column("nombre")]
        [StringLength(60)]
        [Required]
        public string Nombre { get; set; }

        [Column("apellido")]
        [StringLength(60)]
        [Required]
        public string Apellido { get; set; }

        [ForeignKey("idDomicilio")]
        [Required]
        public virtual Domicilio Domicilio { get; set; }

        [Column("mail")]
        [StringLength(60)]
        public string Mail { get; set; }

        [ForeignKey("idDominioMail")]
        public virtual DominioMail DominioMail { get; set; }

        [ForeignKey("idNacionalidad")]
        [Required]
        public virtual Nacionalidad Nacionalidad { get; set; }

        [ForeignKey("idTipoDocumento")]
        [Required]
        public virtual TipoDocumento TipoDocumento { get; set; }

        [Column("nroDocumento")]
        public int NroDocumento { get; set; }

        [Column("nacimiento", TypeName = "Date")]
        [Required]
        public DateTime Nacimiento { get; set; }
        public Persona() { }

        [NotMapped]
        public byte Edad 
        {
            get
            {
                DateTime ahora = DateTime.Today;
                byte edad = Convert.ToByte(ahora.Year - Nacimiento.Year);

                if (ahora.Month < Nacimiento.Month || (ahora.Month == Nacimiento.Month && ahora.Day < Nacimiento.Day))
                    edad--;

                return edad;
            }
        }

        [NotMapped]
        public string MailFull =>
            (Mail != null) ? Mail + '@' + DominioMail.Cadena : null;
    }
}