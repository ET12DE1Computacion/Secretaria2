using DominioSecretaria.Escuela;
using DominioSecretaria.Faltas;
using DominioSecretaria.InfoPersonal;
using Microsoft.EntityFrameworkCore;

namespace DominioSecretaria.ADO
{
    public class Contexto : DbContext
    {
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
        private DbSet<Cursada> Cursadas { get; set; }
        private DbSet<Falta> Falta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO Implementar configuracion externa de configuracion
            
            optionsBuilder.UseMySQL("server=win2012-01;database=proy_intoxica2;user=vchoque;password=saratoga");
            //optionsBuilder.UseMySQL("server=localhost;database=secretaria;user=root;password=root");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
                      
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

            base.OnModelCreating(mb);
        }
    }
}