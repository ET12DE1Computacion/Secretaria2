using DominioSecretaria.InfoPersonal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
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
              .HasForeignKey("idLocalidad");
            mb.Property(d => d.IdDomicilio)
                .HasColumnName("idDomicilio");

            mb.Property(d => d.Calle)
                    .HasColumnName("Calle")
                    .HasMaxLength(45);

            mb.Property(d => d.Altura)
                    .HasColumnName("Altura");

            mb.Property(d => d.Piso)
                    .HasColumnName("Piso");

            mb.Property(d => d.Departamento)
                    .HasColumnName("Departamento")
                    .HasMaxLength(3);

            mb.Property(d => d.CodigoPostal)
                    .HasColumnName("CodigoPostal")
                    .HasMaxLength(8);

            mb.Property(d => d.observacionDomicilio)
                    .HasColumnName("ObservacionDomicilio")
                    .HasMaxLength(60);
        }
    }
}