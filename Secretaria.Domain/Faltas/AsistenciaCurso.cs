using Secretaria.Domain.Escuela;
using System;

namespace Secretaria.Domain.Faltas
{
    public class AsistenciaCurso
    {
        public int IdAsistenciaCurso { get; set; }
        
        public DateTime Fecha { get; set; }

        public Curso Curso { get; set; }
        
        public TipoFalta TipoFalta { get; set; }

        public AsistenciaCurso() 
        {
        
        }
    }
}
