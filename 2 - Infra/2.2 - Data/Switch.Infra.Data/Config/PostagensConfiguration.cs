using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class PostagensConfiguration : IEntityTypeConfiguration<Postagens>
    {
        public void Configure(EntityTypeBuilder<Postagens> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Texto).IsRequired();
        }
    }
}