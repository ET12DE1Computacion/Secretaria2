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

            mb.HasKey(n => n.Id);
            mb.HasIndex(n => n.Cadena).IsUnique();

            mb.Property(n => n.Id)
                .HasColumnName("idNacionalidad");
            mb.Property(n => n.Cadena)
                .HasColumnName("nacionalidad")
                .HasMaxLength(45);
        }
    }
}
