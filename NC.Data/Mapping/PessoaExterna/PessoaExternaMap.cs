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

            builder.Property(e => e.Complemento1)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Complemento2)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Complemento3)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Complemento4)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.ContratacaoFim).HasColumnType("datetime");

            builder.Property(e => e.ContratacaoInicio).HasColumnType("datetime");

            builder.Property(e => e.DataCadastro).HasColumnType("datetime");

            builder.Property(e => e.DocumentoNumero)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.EmpresaId).HasColumnName("EmpresaID");

            builder.Property(e => e.EmpresaNome)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoBairro)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoCep)
                .HasColumnName("EnderecoCEP")
                .HasMaxLength(9)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoCidade)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoComplemento)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoEstado)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoLogradouro)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoNumero)
                .HasMaxLength(6)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoPais)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.ExameMedicoFim).HasColumnType("datetime");

            builder.Property(e => e.ExameMedicoInicio).HasColumnType("datetime");

            builder.Property(e => e.Grupo)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Imagem).HasColumnType("image");

            builder.Property(e => e.IntegracaoFim).HasColumnType("datetime");

            builder.Property(e => e.IntegracaoInicio).HasColumnType("datetime");

            builder.Property(e => e.Nascimento).HasColumnType("datetime");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Observacao)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.PessoaDocTipo)
                .HasMaxLength(4)
                .IsUnicode(false);

            builder.Property(e => e.SegurancaFim).HasColumnType("datetime");

            builder.Property(e => e.SegurancaInicio).HasColumnType("datetime");

            builder.Property(e => e.TelefoneFixo)
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.TelefoneMovel)
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.UltimaVisitaDataHora).HasColumnType("datetime");

            builder.Property(e => e.UltimoMotivo)
                .HasMaxLength(30)
                .IsUnicode(false);

        }
    }
}
