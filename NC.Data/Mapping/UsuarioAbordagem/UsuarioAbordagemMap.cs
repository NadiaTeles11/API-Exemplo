using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NC.Domain.Entities.UsuarioAbordagem;

namespace NC.Data.Mapping.UsuarioAbordagem
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

    
    

