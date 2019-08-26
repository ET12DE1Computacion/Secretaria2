using DominioSecretaria.Escuela;
using DominioSecretaria.InfoPersonal;
using System.Collections.Generic;

namespace DominioSecretaria.ADO
{
    public interface IAdo
    {
        void altaPersona(Persona persona);

        List<Persona> traerPersonas();
        void altaDomicilio(Domicilio domicilio);

        void altaAlumno(Alumno alumno);
        void altaLocalidad(Localidad localidad);
        void altaCurso(Curso curso);

        void altaTipoDocumento(TipoDocumento tipoDocumento);
        void altaNacionalidad(Nacionalidad nacionalidad);
        void altaTipoTutor(TipoTutor tipoTutor);
        void altaTutor(Tutor tutor);
        void altaSeguimiento(Seguimiento seguimiento);
        void altaDominioMail(DominioMail dominioMail);

        List<Localidad> traerLocalidades();
        List<DominioMail> traerDominioMails();
        List<Nacionalidad> traerNacionalidades();
        List<Seguimiento> traerSeguimientos();
        List<TipoDocumento> traerTipoDocumentos();
        List<Alumno> traerAlumnos();
        List<Curso> traerCursos();
        List<Domicilio> traerDomicilios();
    }
}