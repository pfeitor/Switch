using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(g => g.Descricao)
                    .IsRequired()
                    .HasMaxLength(100);
                    
            builder.Property(g => g.UrlFoto)
                    .IsRequired()
                    .HasMaxLength(1000);

            builder.HasMany(g => g.Postagens).WithOne(p => p.Grupo);

        }
    }
}