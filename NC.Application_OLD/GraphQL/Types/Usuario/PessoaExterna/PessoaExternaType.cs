using HotChocolate.Types;
using NexcodeControls.Domain.Entities;

namespace NexcodeControls.Api.GraphQL.Types
{
    public class PessoaExternaType : ObjectType<NcPessoaExterna>
    {
        protected override void Configure(IObjectTypeDescriptor<NcPessoaExterna> descriptor)
        {
            descriptor.Field(b => b.Id).Type<IntType>().Description("Identificação do registro");
            descriptor.Field(b => b.Imagem).Type<AnyType>().Description("Imagem da Pessoa (Foto)");
            descriptor.Field(b => b.Nome).Type<StringType>().Description("Nome da pessoa");
            descriptor.Field(b => b.Grupo).Type<StringType>().Description("Nome do grupo da pessoa");
            descriptor.Field(b => b.TelefoneFixo).Type<StringType>().Description("Número do telefone comercial para contato");
            descriptor.Field(b => b.TelefoneMovel).Type<StringType>().Description("Número do telefone pessoal para contato (Celular)");
            descriptor.Field(b => b.Email).Type<StringType>().Description("Email");
            descriptor.Field(b => b.Observacao).Type<StringType>().Description("Observação de status da pessoa");
            descriptor.Field(b => b.PessoaDocTipo).Type<StringType>().Description("Tipo do documento (ID, RG, CPF, CNH, CREA, CRM, OAB, PAS)");
            descriptor.Field(b => b.DocumentoNumero).Type<StringType>().Description("Número do documento");
            descriptor.Field(b => b.Nascimento).Type<DateTimeType>().Description("Data de nascimento da pessoa");
            descriptor.Field(b => b.EmpresaId).Type<IntType>().Description("Identificação da entidade");
            descriptor.Field(b => b.EmpresaNome).Type<StringType>().Description("Nome da empresa ou entidade");
            descriptor.Field(b => b.Complemento1).Type<StringType>().Description("Dados complementares");
            descriptor.Field(b => b.Complemento2).Type<StringType>().Description("Dados complementares");
            descriptor.Field(b => b.Complemento3).Type<StringType>().Description("Dados complementares");
            descriptor.Field(b => b.Complemento4).Type<StringType>().Description("Dados complementares");
            descriptor.Field(b => b.EnderecoLogradouro).Type<StringType>().Description("Endereco residencial");
            descriptor.Field(b => b.EnderecoNumero).Type<StringType>().Description("Número do endereço");
            descriptor.Field(b => b.EnderecoComplemento).Type<StringType>().Description("Complemento do endereço");
            descriptor.Field(b => b.EnderecoBairro).Type<StringType>().Description("Bairro");
            descriptor.Field(b => b.EnderecoCep).Type<StringType>().Description("Cep");
            descriptor.Field(b => b.EnderecoCidade).Type<StringType>().Description("Cidade");
            descriptor.Field(b => b.EnderecoEstado).Type<StringType>().Description("Estado");
            descriptor.Field(b => b.EnderecoPais).Type<StringType>().Description("País");

            descriptor.Field(b => b.ContratacaoInicio).Type<DateTimeType>().Description("Data inicial contratação (admissão)");
            descriptor.Field(b => b.IntegracaoInicio).Type<DateTimeType>().Description("Data da realização da integração");
            descriptor.Field(b => b.ContratacaoFim).Type<DateTimeType>().Description("Data final de contratação (demissão)");
            descriptor.Field(b => b.IntegracaoFim).Type<DateTimeType>().Description("Data final válida para a integracao");
            descriptor.Field(b => b.SegurancaInicio).Type<DateTimeType>().Description("Data do treinamento básico de segurança");
            descriptor.Field(b => b.SegurancaFim).Type<DateTimeType>().Description("Data final válida do treinamento básico de segurança");
            descriptor.Field(b => b.ExameMedicoInicio).Type<DateTimeType>().Description("Data de inicial do exame médico");
            descriptor.Field(b => b.ExameMedicoFim).Type<DateTimeType>().Description("Data de final do exame médico");

            descriptor.Field(b => b.IgnorarBiometria).Type<BooleanType>().Description("Ignorar o validação biométrica (0-Não, 1-Sim)");
            descriptor.Field(b => b.UltimaVisitaDataHora).Type<DateTimeType>().Description("Data e hora da última visita");
            descriptor.Field(b => b.UltimoVisitadoId).Type<IntType>().Description("Identificação do último visitado");
            descriptor.Field(b => b.UltimoMotivo).Type<StringType>().Description("Motivo da última visita");
            descriptor.Field(b => b.ExPessoaInterna).Type<BooleanType>().Description("Ex Pessoa Interna (0-Não, 1-Sim)");
            descriptor.Field(b => b.DataCadastro).Type<DateTimeType>().Description("Data do cadastro da registro");
            descriptor.Field(b => b.OrigemCadastro).Type<ByteType>().Description("0-Desconhecido, 1-Nexcode Controls, 2-Nexcode Integration, 3-Nexium");
            descriptor.Field(b => b.Presente).Type<BooleanType>().Description("0-Não, 1-Sim");
            descriptor.Field(b => b.AbordagemId).Type<IntType>().Description("0-Nenhuma, 1-Informativa, 2-Especial, 3-Advertida, 4-Restritiva");
            descriptor.Field(b => b.Status).Type<BooleanType>().Description("0-Livre, 1-Bloqueada");
                      

        }
    }
}



