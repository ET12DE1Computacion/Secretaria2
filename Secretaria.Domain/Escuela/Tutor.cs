using Secretaria.Domain.InfoPersonal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Secretaria.Domain.Escuela
{
    public class Tutor : EsPersona
    {
        public int Id { get; set; }

        public Alumno Alumno { get; set; }

        public TipoTutor TipoTutor { get; set; }

        public Tutor() : base() { }

        public Tutor(Persona persona) : base(persona) { }
    }
}
