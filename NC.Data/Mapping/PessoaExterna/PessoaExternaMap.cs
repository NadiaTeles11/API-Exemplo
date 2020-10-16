using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NC.Domain.Entities;

namespace NC.Data.Mapping
{
    public class PessoaExternaMap : IEntityTypeConfiguration<NcPessoaExterna>
    {
        public void Configure(EntityTypeBuilder<NcPessoaExterna> builder)
        {
            builder.ToTable("ncPessoaExterna");

            builder.Property(e => e.Id).HasColumnName("ID");      

            builder.Property(e => e.Grupo)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);          

            builder.Property(e => e.TelefoneFixo)
                .HasMaxLength(15)
                .IsUnicode(false);


        }
    }
}
