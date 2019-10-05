using DominioSecretaria.InfoPersonal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class PersonaConfiguracion : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> mb)
        {
            mb.ToTable("Persona");

            mb.HasKey(l => l.IdPersona);

            mb.Property<byte>("idTipoDocumento");
            mb.HasOne(d => d.TipoDocumento)
                .WithMany()
                .HasForeignKey("idTipoDocumento")
                .IsRequired();

            mb.Property<byte>("idNacionalidad");
            mb.HasOne(d => d.Nacionalidad)
                .WithMany()
                .HasForeignKey("idNacionalidad")
                .IsRequired();

            mb.Property<int>("idDomicilio");
            mb.HasOne(d => d.Domicilio)
                .WithMany()
                .HasForeignKey("idDomicilio")
                .IsRequired();

            mb.Property(d => d.IdPersona)
                .HasColumnName("idPersona");

            mb.Property(d => d.NroDocumento)
                .HasColumnName("nroDocumento")
                .IsRequired();

            mb.Property(d => d.Nombre)
                .HasColumnName("nombre")
                .HasMaxLength(45)
                .IsRequired();

            mb.Property(d => d.Apellido)
                .HasColumnName("apellido")
                .HasMaxLength(45)
                .IsRequired();

            mb.Property(d => d.Nacimiento)
                .HasColumnName("nacimiento")
                .HasColumnType("Date")
                .IsRequired();

            mb.Property(d => d.Telefono1)
                .HasColumnName("telelfono1");

            mb.Property(d => d.Telefono2)
                .HasColumnName("telefono2");

            mb.Property(d => d.Mail)
                .HasColumnName("mail")
                .HasMaxLength(60);
        }
    }
}
