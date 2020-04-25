using Secretaria.Domain.Escuela;
using Secretaria.Domain.InfoPersonal;
using System.Collections.Generic;

namespace Secretaria.Domain.ADO
{
    public interface IAdo<T>
    {
        T obtener(int id);

        IEnumerable<T> obtenerTodo();

        void alta(T entidad);

        void actualizar(T entidad);

        void borrar(T entidad);

        //void altaPersona(Persona persona);

        //List<Persona> traerPersonas();
        //void altaDomicilio(Domicilio domicilio);

        //void altaAlumno(Alumno alumno);
        //void altaLocalidad(Localidad localidad);
        //void altaCurso(Curso curso);

        //void altaTipoDocumento(TipoDocumento tipoDocumento);
        //void altaNacionalidad(Nacionalidad nacionalidad);
        //void altaTipoTutor(TipoTutor tipoTutor);
        //void altaTutor(Tutor tutor);
        //void altaSeguimiento(Seguimiento seguimiento);

        //List<Localidad> traerLocalidades();
        //List<Nacionalidad> traerNacionalidades();
        //List<Seguimiento> traerSeguimientos();
        //List<TipoDocumento> traerTipoDocumentos();
        //List<Alumno> traerAlumnosSinDetalle();
        //List<Curso> traerCursos();
        //List<Domicilio> traerDomicilios();
    }
}