using Secretaria.Domain.InfoPersonal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.ADO.ContextConfiguracion
{
    public class DomicilioConfiguracion : IEntityTypeConfiguration<Domicilio>
    {
        public void Configure(EntityTypeBuilder<Domicilio> mb)
        {
            mb.ToTable("Domicilio");

            mb.HasKey(d => d.IdDomicilio);

            mb.Property<byte>("idLocalidad");
            mb.HasOne(d => d.Localidad)
              .WithMany()
              .HasForeignKey("idLocalidad")
              .IsRequired();

            mb.Property(d => d.IdDomicilio)
                .HasColumnName("idDomicilio");

            mb.Property(d => d.Calle)
                    .HasColumnName("Calle")
                    .HasMaxLength(45)
                    .IsRequired();

            mb.Property(d => d.Altura)
                    .HasColumnName("altura");

            mb.Property(d => d.Piso)
                    .HasColumnName("piso");

            mb.Property(d => d.Departamento)
                    .HasColumnName("departamento")
                    .HasMaxLength(3);

            mb.Property(d => d.CodigoPostal)
                    .HasColumnName("codigoPostal")
                    .HasMaxLength(8);

            mb.Property(d => d.observacionDomicilio)
                    .HasColumnName("observacionDomicilio")
                    .HasMaxLength(60);
        }
    }
}