using DominioSecretaria.InfoPersonal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class NacionalidadConfiguracion : IEntityTypeConfiguration<Nacionalidad>
    {
        public void Configure(EntityTypeBuilder<Nacionalidad> mb)
        {
            mb.ToTable("Nacionalidad");

            mb.HasIndex(l => l.Cadena).IsUnique();

            mb.Property(l => l.Cadena)
                .HasColumnName("Nacionalidad")
                .HasMaxLength(45);
        }
    }
}
