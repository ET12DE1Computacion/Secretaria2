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

            mb.HasIndex(l => l.Cadena).IsUnique();
                        
            mb.Property(l => l.Cadena)
                .HasColumnName("Localidad")
                .HasMaxLength(45);                
        }
    }
}