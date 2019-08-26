﻿using DominioSecretaria.Escuela;
using DominioSecretaria.InfoPersonal;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DominioSecretaria.ADO
{
    public class AdoEntityCoreMySQL : IAdo
    {
        public Contexto Contexto { get; set; }
        public void altaAlumno(Alumno alumno)
        {
            Contexto.Alumnos.Add(alumno);
            Contexto.SaveChanges();
        }

        public void altaCurso(Curso curso)
        {
            Contexto.Cursos.Add(curso);
            Contexto.SaveChanges();
        }

        public void altaDomicilio(Domicilio domicilio)
        {
            Contexto.Domicilios.Add(domicilio);
            Contexto.SaveChanges();
        }

        public void altaDominioMail(DominioMail dominioMail)
        {
            Contexto.DominiosMails.Add(dominioMail);
            Contexto.SaveChanges();
        }

        public void altaLocalidad(Localidad localidad)
        {
            Contexto.Localidades.Add(localidad);
            Contexto.SaveChanges();
        }

        public void altaNacionalidad(Nacionalidad nacionalidad)
        {
            Contexto.Nacionalidades.Add(nacionalidad);
            Contexto.SaveChanges();
        }

        public void altaPersona(Persona persona)
        {
            Contexto.Personas.Add(persona);
            Contexto.SaveChanges();
        }

        public void altaSeguimiento(Seguimiento seguimiento)
        {
            Contexto.Seguimientos.Add(seguimiento);
            Contexto.SaveChanges();
        }

        public void altaTipoDocumento(TipoDocumento tipoDocumento)
        {
            Contexto.TipoDocumentos.Add(tipoDocumento);
            Contexto.SaveChanges();
        }

        public void altaTipoTutor(TipoTutor tipoTutor)
        {
            Contexto.TipoTutores.Add(tipoTutor);
            Contexto.SaveChanges();
        }

        public void altaTutor(Tutor tutor)
        {
            //Contexto.Tutores.Add(tutor);
            Contexto.SaveChanges();
        }
        //public List<TipoDocumento> traerTipoDocumentos() => Contexto.TipoDocumentos.ToList();
        //public List<Seguimiento> traerSeguiminetos() => Contexto.Seguimientos.ToList();


        public List<Persona> traerPersonas()
        {
            return Contexto.Personas
                    .Include(p => p.DominioMail)
                    .Include(p => p.TipoDocumento)
                    .Include(p => p.Nacionalidad)
                    .Include(p => p.Domicilio.Localidad)
                    .Include(p => p.Domicilio)
                    .ToList();
        }
        public List<Nacionalidad> traerNacionalidades() => Contexto.Nacionalidades.ToList();
        public List<DominioMail> traerDominioMails() => Contexto.DominiosMails.ToList();
        public List<Localidad> traerLocalidades() => Contexto.Localidades.ToList();

        public List<Seguimiento> traerSeguimientos() => Contexto.Seguimientos.ToList();

        public List<TipoDocumento> traerTipoDocumentos() => Contexto.TipoDocumentos.ToList();

        public List<Alumno> traerAlumnos() => Contexto.Alumnos.ToList();

        public List<Curso> traerCursos() => Contexto.Cursos.ToList();

        public List<Domicilio> traerDomicilios() => Contexto.Domicilios.ToList();
    }
}
