using DominioSecretaria.Escuela;
using System;

namespace DominioSecretaria.Faltas
{
    public class AsistenciaCurso
    {
        public int idAsistenciaCurso { get; set; }
        public Curso idCurso { get; set; }
        public DateTime falta { get; set; }
        public TipoFalta idTipoFalta { get; set; }

        public AsistenciaCurso() { }
    }
}
