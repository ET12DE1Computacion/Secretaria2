using DominioSecretaria.InfoPersonal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class LocalidadConfiguracion : IEntityTypeConfiguration<Localidad>
    {
        public void Configure(EntityTypeBuilder<Localidad> mb)
        {
            mb.ToTable("Localidad");

            mb.HasKey(l => l.Id);
            mb.HasIndex(l => l.Cadena).IsUnique();

            mb.Property(l => l.Id)
                .HasColumnName("idLocalidad");
            mb.Property(l => l.Cadena)
                .HasColumnName("localidad")
                .HasMaxLength(45);                
        }
    }
}