using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class StatusRelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Descricao)
                .IsRequired();

            builder.HasData(
                new StatusRelacionamento(){Id = 1,Descricao = "NaoEspecificado"},
                new StatusRelacionamento(){Id = 2,Descricao = "Solteiro"},
                new StatusRelacionamento(){Id = 3,Descricao = "Casado"},
                new StatusRelacionamento(){Id = 4,Descricao = "EmRelacionamentoSerio"}
            );
        }
    }
}