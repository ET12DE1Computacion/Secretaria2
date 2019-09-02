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

            mb.HasKey(l => l.Id);
            mb.HasIndex(l => l.Cadena).IsUnique();

            mb.Property(l => l.Id)
                .HasColumnName("idTipoDocumento");
            mb.Property(l => l.Cadena)
                .HasColumnName("tipoDocumento")
                .HasMaxLength(45);
        }
    }
}
