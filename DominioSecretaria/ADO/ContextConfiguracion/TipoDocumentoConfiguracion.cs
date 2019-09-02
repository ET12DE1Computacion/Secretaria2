using DominioSecretaria.InfoPersonal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class TipoDocumentoConfiguracion : IEntityTypeConfiguration<TipoDocumento>
    {
        public void Configure(EntityTypeBuilder<TipoDocumento> mb)
        {
            mb.ToTable("TipoDocumento");

            mb.HasIndex(l => l.Cadena).IsUnique();

            mb.Property(l => l.Cadena)
                .HasColumnName("TipoDocumento")
                .HasMaxLength(45);
        }
    }
}
