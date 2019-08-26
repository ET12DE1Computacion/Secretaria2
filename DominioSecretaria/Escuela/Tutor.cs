using DominioSecretaria.InfoPersonal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioSecretaria.Escuela
{
    //[Table("Tutor")]
    [NotMapped]
    public class Tutor : EsPersona
    {
        [Key, Column("idTutor")]
        public int Id { get; set; }

        [ForeignKey("legajo"),Required]
        public Alumno Alumno { get; set; }

        [ForeignKey("idTipoTutor"),Required]
        public TipoTutor TipoTutor { get; set; }

        public Tutor() : base() { }
        public Tutor(Persona persona) : base(persona) { }
    }
}
