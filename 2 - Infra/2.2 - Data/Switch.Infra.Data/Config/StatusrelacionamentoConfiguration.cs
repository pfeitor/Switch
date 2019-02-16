using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class StatusrelacionamentoConfiguration : IEntityTypeConfiguration<Statusrelacionamento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Statusrelacionamento> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Descricao).IsRequired();
        }
    }
}