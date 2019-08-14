using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.InfoPersonal
{
    [Table("Domicilio")]
    public class Domicilio
    {
        [Key]
        [Column("idDomicilio")]
        public int IdDomicilio { get; set; }

        [Column("calle")]
        [StringLength(45)]
        [Required]
        public string Calle { get; set; }

        [Column("altura")]
        public int? Altura { get; set; }

        [Column("piso")]
        public byte? Piso { get; set; }

        [Column("departamento")]
        [StringLength(3)]
        public string Departamento { get; set; }

        [Column("codigoPostal")]
        [StringLength(8)]
        public string CodigoPostal { get; set; }

        [ForeignKey("idLocalidad")]
        [Required]
        public virtual Localidad Localidad { get; set; }

        public Domicilio() { }
        public Domicilio(Localidad localidad)
        {
            this.Localidad = localidad;
        }
    }
}