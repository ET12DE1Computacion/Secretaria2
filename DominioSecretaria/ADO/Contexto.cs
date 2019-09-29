using DominioSecretaria.ADO.ContextConfiguracion;
using DominioSecretaria.Escuela;
using DominioSecretaria.Faltas;
using DominioSecretaria.InfoPersonal;
using Microsoft.EntityFrameworkCore;

namespace DominioSecretaria.ADO
{
    public class Contexto : DbContext
    {
        public Contexto()
        {

        }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        internal DbSet<TipoDocumento> TipoDocumentos { get; set; }
        internal DbSet<Nacionalidad> Nacionalidades { get; set; }
        internal DbSet<DominioMail> DominiosMails { get; set; }
        internal DbSet<TipoTutor> TipoTutores { get; set; }
        //internal DbSet<Tutor> Tutores { get; set; }
        internal DbSet<Seguimiento> Seguimientos { get; set; }
        public DbSet<Cursada> Cursadas { get; set; }
        private DbSet<Falta> Falta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
             
            mb.Entity<TipoTutor>(entidad =>
            {
                entidad.HasIndex(l => l.Cadena)
                        .IsUnique();

                entidad.Property(l => l.Id)
                        .HasColumnName("idTipoTutor");

                entidad.Property(l => l.Cadena)
                        .HasColumnName("tipoTutor")
                        .HasMaxLength(15);

                entidad.Property(l => l.Cadena)
                        .HasColumnName("dominio")
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

            mb.ApplyConfiguration<Localidad>(new LocalidadConfiguracion());

            mb.ApplyConfiguration<Nacionalidad>(new NacionalidadConfiguracion());

            mb.ApplyConfiguration<TipoDocumento>(new TipoDocumentoConfiguracion());

            mb.ApplyConfiguration<Domicilio>(new DomicilioConfiguracion());

            mb.ApplyConfiguration<Persona>(new PersonaConfiguracion());

            mb.ApplyConfiguration<Cursada>(new CursadaConfiguracion());

            mb.ApplyConfiguration<Seguimiento>(new SeguimientoConfiguracion());

            mb.ApplyConfiguration<TipoTutor>(new TipoTutorConfiguracion());

            mb.ApplyConfiguration<Tutor>(new TutorConfiguracion());

            base.OnModelCreating(mb);
        }
    }
}