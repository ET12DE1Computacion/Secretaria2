using DominioSecretaria.Escuela;
using DominioSecretaria.InfoPersonal;
using DominioSecretaria.Faltas;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DominioSecretaria.ADO
{
    public class AdoEntityCoreMySQL : DbContext, IAdo
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        private DbSet<TipoDocumento> TipoDocumentos { get; set; }
        private DbSet<Nacionalidad> Nacionalidades { get; set; }
        private DbSet<DominioMail> DominiosMails { get; set; }
        private DbSet<TipoTutor> TipoTutores { get; set; }
        private DbSet<Tutor> Tutores { get; set; }
        private DbSet<Seguimiento> Seguimientos { get; set; }
        private DbSet<Cursada> Cursadas { get; set; }
        private DbSet<Falta> Falta { get; set; }

        public void altaAlumno(Alumno alumno)
        {
            Alumnos.Add(alumno);
            SaveChanges();
        }

        public void altaCurso(Curso curso)
        {
            Cursos.Add(curso);
            SaveChanges();
        }

        public void altaDomicilio(Domicilio domicilio)
        {
            Domicilios.Add(domicilio);
            SaveChanges();
        }

        public void altaDominioMail(DominioMail dominioMail)
        {
            DominiosMails.Add(dominioMail);
            SaveChanges();
        }

        public void altaLocalidad(Localidad localidad)
        {
            Localidades.Add(localidad);
            SaveChanges();
        }

        public void altaNacionalidad(Nacionalidad nacionalidad)
        {
            Nacionalidades.Add(nacionalidad);
            SaveChanges();
        }

        public void altaPersona(Persona persona)
        {
            Personas.Add(persona);
            SaveChanges();
        }

        public void altaSeguimiento(Seguimiento seguimiento)
        {
            Seguimientos.Add(seguimiento);
            SaveChanges();
        }

        public void altaTipoDocumento(TipoDocumento tipoDocumento)
        {
            TipoDocumentos.Add(tipoDocumento);
            SaveChanges();
        }

        public void altaTipoTutor(TipoTutor tipoTutor)
        {
            TipoTutores.Add(tipoTutor);
            SaveChanges();
        }

        public void altaTutor(Tutor tutor)
        {
            Tutores.Add(tutor);
            SaveChanges();
        }

        public List<Persona> traerPersonas()
        {
            return Personas
                    .Include(p => p.DominioMail)
                    .Include(p => p.TipoDocumento)
                    .Include(p => p.Nacionalidad)
                    .Include(p => p.Domicilio.Localidad)
                    .Include(p => p.Domicilio)
                    .ToList();
        }

        public List<Alumno> traerAlumnos()
        {
            return Alumnos
                    .Include(a => a.Persona)
                    .Include(a => a.CursoActual)
                    .ToList();
        }
        public List<Seguimiento> traerSeguimientos()
        {
            return Seguimientos.Include(s => s.Alumno).ToList();
        }
        public List<Curso> traerCursos()
        {
            return Cursos.ToList();
        }
        public List<Cursada> traerCursadas(Alumno alumno)
        {
            return Cursadas.Where(c => c.Alumno.legajo == alumno.legajo).ToList();
        }
        public List<TipoDocumento> traerTipoDocumentos()
        {
            return TipoDocumentos.ToList();
        }

        public List<Nacionalidad> traerNacionalidades()
        {
            return Nacionalidades.ToList();
        }
        public List<DominioMail> traerDominioMails()
        {
            return DominiosMails.ToList();
        }
        public List<Localidad> traerLocalidades()
        {
            return Localidades.ToList();
        }
        public List<Domicilio> traerDomicilios()
        {
            return Domicilios.Include(d => d.Localidad).ToList();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO Implementar configuracion externa de configuracion
            optionsBuilder.UseMySQL("server=win2012-01;database=proy_intoxica2;user=vchoque;password=saratoga");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Alumno>(entidad=>
            {
                entidad.HasIndex(a => new { a.Libro, a.Folio })
                        .IsUnique();
            });

            mb.Entity<Localidad>(entidad =>
            {
                entidad.HasIndex(l => l.Cadena)
                        .IsUnique();

                entidad.Property(l => l.Id)
                        .HasColumnName("idLocalidad");

                entidad.Property(l => l.Cadena)
                        .HasColumnName("localidad")
                        .HasMaxLength(60);
            });

            mb.Entity<TipoDocumento>(entidad =>
            {
                entidad.HasIndex(l => l.Cadena)
                        .IsUnique();

                entidad.Property(l => l.Id)
                        .HasColumnName("idTipoDocumento");

                entidad.Property(l => l.Cadena)
                        .HasColumnName("tipoDocumento")
                        .HasMaxLength(35);
            });

            mb.Entity<Nacionalidad>(entidad =>
            {
                entidad.HasIndex(l => l.Cadena)
                        .IsUnique();

                entidad.Property(l => l.Id)
                        .HasColumnName("idNacionalidad");

                entidad.Property(l => l.Cadena)
                        .HasColumnName("nacionalidad")
                        .HasMaxLength(25);
            });

            mb.Entity<TipoTutor>(entidad =>
            {
                entidad.HasIndex(l => l.Cadena)
                        .IsUnique();

                entidad.Property(l => l.Id)
                        .HasColumnName("idTipoTutor");

                entidad.Property(l => l.Cadena)
                        .HasColumnName("tipoTutor")
                        .HasMaxLength(15);
            });

            mb.Entity<DominioMail>(entidad =>
            {
                entidad.HasIndex(l => l.Cadena)
                        .IsUnique();

                entidad.Property(l => l.Id)
                        .HasColumnName("idDominioMail");

                entidad.Property(l => l.Cadena)
                        .HasColumnName("dominioMail")
                        .HasMaxLength(35);
            });

            mb.Entity<TipoFalta>(entidad =>
            {
                entidad.HasIndex(l => l.Cadena)
                        .IsUnique();

                entidad.Property(l => l.Id)
                        .HasColumnName("idTipoFalta");

                entidad.Property(l => l.Cadena)
                        .HasColumnName("tipoFalta")
                        .HasMaxLength(30);
            });
        }
    }
}