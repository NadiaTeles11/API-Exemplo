using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexcodeControls.Domain.Entities;

namespace NexcodeControls.Data.Mapping.Entidade
{
    public class EmpresaMap : IEntityTypeConfiguration<NcEmpresa>
    {
        public void Configure(EntityTypeBuilder<NcEmpresa> builder)
        {
            builder.ToTable("ncEmpresa");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.Cnpj)
                .HasColumnName("CNPJ")
                .HasMaxLength(18)
                .IsUnicode(false);

            builder.Property(e => e.Complemento1)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Complemento2)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.DataCadastro).HasColumnType("datetime");

            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoBairro)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoCep)
                .HasColumnName("EnderecoCEP")
                .HasMaxLength(9)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoCidade)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoComplemento)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoEstado)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoLogradouro)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoNumero)
                .HasMaxLength(6)
                .IsUnicode(false);

            builder.Property(e => e.EnderecoPais)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Gestor)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Grupo)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Ie)
                .HasColumnName("IE")
                .HasMaxLength(9)
                .IsUnicode(false);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Observacao)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Telefone1)
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.Telefone2)
                .HasMaxLength(15)
                .IsUnicode(false);


        }

    }
}



