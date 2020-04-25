using Secretaria.Domain.Escuela;
using Secretaria.Domain.InfoPersonal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Secretaria.Domain.ADO
{
    public class AdoEntityCoreMySQL
    {
        //    public SecretariaDbContext Contexto { get; set; }

        //    public AdoEntityCoreMySQL()
        //    {
        //        Contexto = new SecretariaDbContext();
        //    }

        //    public AdoEntityCoreMySQL(SecretariaDbContext contexto)
        //    {
        //        this.Contexto = contexto;
        //    }

        //    public void altaAlumno(Alumno alumno)
        //    {
        //        Contexto.Alumnos.Add(alumno);
        //        Contexto.SaveChanges();
        //    }

        //    public void altaCurso(Curso curso)
        //    {
        //        Contexto.Cursos.Add(curso);
        //        Contexto.SaveChanges();
        //    }

        //    public void altaDomicilio(Domicilio domicilio)
        //    {
        //        Contexto.Domicilios.Add(domicilio);
        //        Contexto.SaveChanges();
        //    }

        //    public Alumno traerAlumnoById(int id)
        //    {
        //        return Contexto.Alumnos.FirstOrDefault(x => x.legajo == id);
        //    }
        //    public Curso traerCursoById(int id)
        //    {
        //        return Contexto.Cursos.FirstOrDefault(x => x.IdCurso == id);
        //    }

        //    public Domicilio traerDomicilioById(int id)
        //    {
        //        return Contexto.Domicilios.FirstOrDefault(x => x.IdDomicilio == id);
        //    }

        //    public void bajaNacionalidad(int id)
        //    {
        //        var nacionalidad = Contexto.Nacionalidades.FirstOrDefault(x => x.Id == id);
        //        if (nacionalidad != null)
        //        {
        //            Contexto.Nacionalidades.Remove(nacionalidad);
        //            Contexto.SaveChanges();
        //        }
        //    }

        //    public Localidad traerLocalidadById(byte id)
        //    {
        //        return Contexto.Localidades.FirstOrDefault(x => x.Id == id);
        //    }

        //    public Seguimiento traerSeguimientoById(int id)
        //    {
        //        return Contexto.Seguimientos.FirstOrDefault(x => x.IdSeguimiento == id);
        //    }

        //    public TipoDocumento traerTipoDocumentoById(int id)
        //    {
        //        return Contexto.TipoDocumentos.FirstOrDefault(x => x.Id == id);
        //    }

        //    public Persona traerPersonasById(int id)
        //    {
        //        return Contexto.Personas.FirstOrDefault(x => x.IdPersona == id);
        //    }

        //    public Nacionalidad traerNacionalidadById(int id)
        //    {
        //        return Contexto.Nacionalidades.FirstOrDefault(x => x.Id == id);
        //    }

        //    public void altaLocalidad(Localidad localidad)
        //    {
        //        Contexto.Localidades.Add(localidad);
        //        Contexto.SaveChanges();
        //    }

        //    public void altaNacionalidad(Nacionalidad nacionalidad)
        //    {
        //        Contexto.Nacionalidades.Add(nacionalidad);
        //        Contexto.SaveChanges();
        //    }

        //    public void altaPersona(Persona persona)
        //    {
        //        Contexto.Personas.Add(persona);
        //        Contexto.SaveChanges();
        //    }

        //    public void altaSeguimiento(Seguimiento seguimiento)
        //    {
        //        Contexto.Seguimientos.Add(seguimiento);
        //        Contexto.SaveChanges();
        //    }

        //    public void altaTipoDocumento(TipoDocumento tipoDocumento)
        //    {
        //        Contexto.TipoDocumentos.Add(tipoDocumento);
        //        Contexto.SaveChanges();
        //    }

        //    public void altaTipoTutor(TipoTutor tipoTutor)
        //    {
        //        Contexto.TipoTutores.Add(tipoTutor);
        //        Contexto.SaveChanges();
        //    }

        //    public void altaTutor(Tutor tutor)
        //    {
        //        //Contexto.Tutores.Add(tutor);
        //        Contexto.SaveChanges();
        //    }
        //    //public List<TipoDocumento> traerTipoDocumentos() => Contexto.TipoDocumentos.ToList();
        //    //public List<Seguimiento> traerSeguiminetos() => Contexto.Seguimientos.ToList();


        //    public List<Persona> traerPersonas()
        //    {
        //        return Contexto.Personas
        //                .Include(p => p.TipoDocumento)
        //                .Include(p => p.Nacionalidad)
        //                .Include(p => p.Domicilio.Localidad)
        //                .Include(p => p.Domicilio)
        //                .ToList();
        //    }
        //    public List<Nacionalidad> traerNacionalidades() => Contexto.Nacionalidades.ToList();

        //    public List<Localidad> traerLocalidades() => Contexto.Localidades.ToList();

        //    public List<Seguimiento> traerSeguimientos() => Contexto.Seguimientos.ToList();

        //    public List<TipoDocumento> traerTipoDocumentos() => Contexto.TipoDocumentos.ToList();

        //    public List<Alumno> traerAlumnosSinDetalle()
        //    {
        //        return Contexto.Alumnos.Include(x => x.Persona)
        //            .Include(x => x.CursoActual).ToList();
        //    }

        //    public List<Alumno> traerAlumnosConDetalle()
        //    {
        //        return Contexto.Alumnos
        //            .Include(x=>x.CursoActual)
        //            .Include(x => x.Persona)
        //                .ThenInclude(x => x.TipoDocumento)
        //            .Include(x=>x.Persona)
        //                .ThenInclude(x=>x.Nacionalidad)
        //            .Include(x => x.Persona)
        //                .ThenInclude(x => x.Domicilio)
        //                    .ThenInclude(x => x.Localidad)
        //            .ToList();

        //    }

        //    public List<Curso> traerCursos() => Contexto.Cursos.ToList();

        //    public List<Domicilio> traerDomicilios() => Contexto.Domicilios.ToList();
        //    public List<Cursada> traerCursada()
        //    {
        //        return Contexto.Cursadas.Include(x => x.Curso).ToList();          
        //    }
        //}
    }
}
