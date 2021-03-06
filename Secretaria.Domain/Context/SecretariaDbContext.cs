﻿
using Secretaria.Domain.ADO.ContextConfiguracion;
using Secretaria.Domain.Escuela;
using Secretaria.Domain.Faltas;
using Secretaria.Domain.InfoPersonal;
using Microsoft.EntityFrameworkCore;

namespace Secretaria.Domain.ADO
{
    public class SecretariaDbContext : DbContext
    {
        public SecretariaDbContext()
        {

        }

        public SecretariaDbContext(DbContextOptions<SecretariaDbContext> options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        internal DbSet<TipoDocumento> TipoDocumentos { get; set; }
        internal DbSet<Nacionalidad> Nacionalidades { get; set; }
        internal DbSet<TipoTutor> TipoTutores { get; set; }
        internal DbSet<Tutor> Tutores { get; set; }
        internal DbSet<Seguimiento> Seguimientos { get; set; }
        public DbSet<Cursada> Cursadas { get; set; }
        private DbSet<Falta> Falta { get; set; }
        public DbSet<TipoAusencia> TipoAusencias { get; set; }
        public DbSet<TipoFalta> TipoFaltas { get; set; }
        public DbSet<AsistenciaCurso> AsistenciaCursos { get; set; }
        public DbSet<Falta> Faltas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {           
            mb.ApplyConfiguration(new LocalidadConfiguracion());

            mb.ApplyConfiguration(new NacionalidadConfiguracion());

            mb.ApplyConfiguration(new TipoDocumentoConfiguracion());

            mb.ApplyConfiguration(new DomicilioConfiguracion());

            mb.ApplyConfiguration(new PersonaConfiguracion());

            mb.ApplyConfiguration(new CursadaConfiguracion());

            mb.ApplyConfiguration(new SeguimientoConfiguracion());

            mb.ApplyConfiguration(new TipoTutorConfiguracion());

            mb.ApplyConfiguration(new TutorConfiguracion());

            mb.ApplyConfiguration(new AlumnoConfiguracion());

            mb.ApplyConfiguration(new CursoConfiguracion());

            mb.ApplyConfiguration(new AsistenciaCursoConfiguracion());

            mb.ApplyConfiguration(new TipoAusenciaConfiguracion());

            mb.ApplyConfiguration(new TipoFaltaConfiguracion());
            
            mb.ApplyConfiguration(new FaltaConfiguracion());

            base.OnModelCreating(mb);
        }
    }
}