using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexcodeControls.Domain.Entities.UsuarioAbordagem;

namespace NexcodeControls.Data.Mapping.UsuarioAbordagem
{
    public class UsuarioAbordagemMap : IEntityTypeConfiguration<NcUsuarioAbordagem>
    {
        public void Configure(EntityTypeBuilder<NcUsuarioAbordagem> builder)
    {
            builder.ToTable("ncUsuarioAbordagem");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.Mensagem).IsUnicode(false);

        }
}
}

    
    

