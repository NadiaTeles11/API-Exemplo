using HotChocolate.Types;
using NexcodeControls.Domain.Commands;
using NexcodeControls.Domain.Commands.PessoaExterna;
using NexcodeControls.Domain.Entities;
using NexcodeControls.Domain.Handlers;

namespace NexcodeControls.Api.GraphQL.Mutations
{
    [ExtendObjectType(Name = "Mutation")]
    public class UsuarioPessoaExternaMutation
    {
        private readonly InserirPessoaExternaCommand _inserirCommand;
        private readonly PessoaExternaHandler _handler;
        public UsuarioPessoaExternaMutation(InserirPessoaExternaCommand inserirCommand,           
            PessoaExternaHandler handler)
        {
            _inserirCommand = inserirCommand;           
            _handler = handler;
        }

        public GenericCommandResult UsuarioPessoaExterna_Inserir(Sessao sessao, InserirPessoaExternaCommand pessoaexterna)
        {
            //_inserirCommand.sessao = sessao;
          //  _inserirCommand.Imagem = pessoaexterna.Imagem;
            _inserirCommand.Nome = pessoaexterna.Nome;
            _inserirCommand.Grupo = pessoaexterna.Grupo;
            //_inserirCommand.TelefoneFixo = pessoaexterna.TelefoneFixo;
            //_inserirCommand.TelefoneMovel = pessoaexterna.TelefoneMovel;
            //_inserirCommand.Email = pessoaexterna.Email;
            //_inserirCommand.Observacao = pessoaexterna.Observacao;
            //_inserirCommand.PessoaDocTipo = pessoaexterna.PessoaDocTipo;
            //_inserirCommand.DocumentoNumero = pessoaexterna.DocumentoNumero;
            //_inserirCommand.Nascimento = pessoaexterna.Nascimento;
            //_inserirCommand.EmpresaId = pessoaexterna.EmpresaId;
            //_inserirCommand.EmpresaNome = pessoaexterna.EmpresaNome;
            //_inserirCommand.Complemento1 = pessoaexterna.Complemento1;
            //_inserirCommand.Complemento2 = pessoaexterna.Complemento2;
            //_inserirCommand.Complemento3 = pessoaexterna.Complemento3;
            //_inserirCommand.Complemento4 = pessoaexterna.Complemento4;
            //_inserirCommand.EnderecoLogradouro = pessoaexterna.EnderecoLogradouro;
            //_inserirCommand.EnderecoNumero = pessoaexterna.EnderecoNumero;
            //_inserirCommand.EnderecoComplemento = pessoaexterna.EnderecoComplemento;
            //_inserirCommand.EnderecoBairro = pessoaexterna.EnderecoBairro;
            //_inserirCommand.EnderecoCep = pessoaexterna.EnderecoCep;
            //_inserirCommand.EnderecoCidade = pessoaexterna.EnderecoCidade;
            //_inserirCommand.EnderecoEstado = pessoaexterna.EnderecoEstado;
            //_inserirCommand.EnderecoPais = pessoaexterna.EnderecoPais;
            //_inserirCommand.ContratacaoInicio = pessoaexterna.ContratacaoInicio;
            //_inserirCommand.IntegracaoInicio = pessoaexterna.IntegracaoInicio;
            //_inserirCommand.ContratacaoFim = pessoaexterna.ContratacaoFim;
            //_inserirCommand.IntegracaoFim = pessoaexterna.IntegracaoFim;
            //_inserirCommand.SegurancaInicio = pessoaexterna.SegurancaInicio;
            //_inserirCommand.SegurancaFim = pessoaexterna.SegurancaFim;
            //_inserirCommand.ExameMedicoInicio = pessoaexterna.ExameMedicoInicio;
            //_inserirCommand.ExameMedicoFim = pessoaexterna.ExameMedicoFim;
            //_inserirCommand.IgnorarBiometria = pessoaexterna.IgnorarBiometria;
            //_inserirCommand.UltimaVisitaDataHora = pessoaexterna.UltimaVisitaDataHora;
            //_inserirCommand.UltimoVisitadoId = pessoaexterna.UltimoVisitadoId;
            //_inserirCommand.UltimoMotivo = pessoaexterna.UltimoMotivo;
            //_inserirCommand.ExPessoaInterna = pessoaexterna.ExPessoaInterna;
            //_inserirCommand.DataCadastro = pessoaexterna.DataCadastro;
            //_inserirCommand.OrigemCadastro = pessoaexterna.OrigemCadastro;
            //_inserirCommand.Presente = pessoaexterna.Presente;
            //_inserirCommand.Abordagem = pessoaexterna.Abordagem;
            //_inserirCommand.Status = pessoaexterna.Status;

            //return await (GenericCommandResult)handler.Handle(command);
            return (GenericCommandResult)_handler.Handle(_inserirCommand);
        }

    }
}