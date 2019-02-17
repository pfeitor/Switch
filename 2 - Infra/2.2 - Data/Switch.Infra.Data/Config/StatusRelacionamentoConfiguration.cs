using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class StatusRelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Descricao).IsRequired();
        }
    }
}