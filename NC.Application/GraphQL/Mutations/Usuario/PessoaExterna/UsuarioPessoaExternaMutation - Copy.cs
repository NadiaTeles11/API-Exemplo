using HotChocolate.Types;
using Microsoft.AspNetCore.Mvc;
using NC.Api.GraphQL.Mutations.PessoaExterna;
using NC.Domain.Commands;
using NC.Domain.Commands.PessoaExterna;
using NC.Domain.Entities;
using NC.Domain.Handlers;

namespace NC.Api.GraphQL.Mutations
{
    //[ExtendObjectType(Name = "Mutation")]
    //public class UsuarioPessoaExternaMutation
    //{
    //    private readonly InserirPessoaExternaCommand _inserirCommand;
    //    private readonly AlterarPessoaExternaCommand _alterarCommand;
    //    private readonly ExcluirPessoaExternaCommand _excluirCommand;

    //    private readonly PessoaExternaHandler _handler;
    //    public UsuarioPessoaExternaMutation(InserirPessoaExternaCommand inserirCommand,
    //        AlterarPessoaExternaCommand alterarCommand,
    //        ExcluirPessoaExternaCommand excluirCommand,
    //        PessoaExternaHandler handler)
    //    {
    //        _inserirCommand = inserirCommand;
    //        _alterarCommand = alterarCommand;
    //        _excluirCommand = excluirCommand;
    //        _handler = handler;
    //    }

    //    public GenericCommandResult UsuarioPessoaExterna_Inserir(Sessao sessao, InserirPessoaExternaCommand pessoaexterna)
    //    {
    //        _inserirCommand.Imagem = pessoaexterna.Imagem;
    //        _inserirCommand.Nome = pessoaexterna.Nome;
    //        _inserirCommand.Grupo = pessoaexterna.Grupo;
    //        _inserirCommand.TelefoneFixo = pessoaexterna.TelefoneFixo;
    //        _inserirCommand.TelefoneMovel = pessoaexterna.TelefoneMovel;
    //        _inserirCommand.Email = pessoaexterna.Email;
    //        _inserirCommand.Observacao = pessoaexterna.Observacao;
    //        _inserirCommand.PessoaDocTipo = pessoaexterna.PessoaDocTipo;
    //        _inserirCommand.DocumentoNumero = pessoaexterna.DocumentoNumero;
    //        _inserirCommand.Nascimento = pessoaexterna.Nascimento;
    //        _inserirCommand.EmpresaId = pessoaexterna.EmpresaId;
    //        _inserirCommand.EmpresaNome = pessoaexterna.EmpresaNome;
    //        _inserirCommand.Complemento1 = pessoaexterna.Complemento1;
    //        _inserirCommand.Complemento2 = pessoaexterna.Complemento2;
    //        _inserirCommand.Complemento3 = pessoaexterna.Complemento3;
    //        _inserirCommand.Complemento4 = pessoaexterna.Complemento4;
    //        _inserirCommand.EnderecoLogradouro = pessoaexterna.EnderecoLogradouro;
    //        _inserirCommand.EnderecoNumero = pessoaexterna.EnderecoNumero;
    //        _inserirCommand.EnderecoComplemento = pessoaexterna.EnderecoComplemento;
    //        _inserirCommand.EnderecoBairro = pessoaexterna.EnderecoBairro;
    //        _inserirCommand.EnderecoCep = pessoaexterna.EnderecoCep;
    //        _inserirCommand.EnderecoCidade = pessoaexterna.EnderecoCidade;
    //        _inserirCommand.EnderecoEstado = pessoaexterna.EnderecoEstado;
    //        _inserirCommand.EnderecoPais = pessoaexterna.EnderecoPais;
    //        _inserirCommand.ContratacaoInicio = pessoaexterna.ContratacaoInicio;
    //        _inserirCommand.IntegracaoInicio = pessoaexterna.IntegracaoInicio;
    //        _inserirCommand.ContratacaoFim = pessoaexterna.ContratacaoFim;
    //        _inserirCommand.IntegracaoFim = pessoaexterna.IntegracaoFim;
    //        _inserirCommand.SegurancaInicio = pessoaexterna.SegurancaInicio;
    //        _inserirCommand.SegurancaFim = pessoaexterna.SegurancaFim;
    //        _inserirCommand.ExameMedicoInicio = pessoaexterna.ExameMedicoInicio;
    //        _inserirCommand.ExameMedicoFim = pessoaexterna.ExameMedicoFim;
    //        _inserirCommand.IgnorarBiometria = pessoaexterna.IgnorarBiometria;
    //        _inserirCommand.UltimaVisitaDataHora = pessoaexterna.UltimaVisitaDataHora;
    //        _inserirCommand.UltimoVisitadoId = pessoaexterna.UltimoVisitadoId;
    //        _inserirCommand.UltimoMotivo = pessoaexterna.UltimoMotivo;
    //        _inserirCommand.ExPessoaInterna = pessoaexterna.ExPessoaInterna;
    //        _inserirCommand.DataCadastro = pessoaexterna.DataCadastro;
    //        _inserirCommand.OrigemCadastro = pessoaexterna.OrigemCadastro;
    //        _inserirCommand.Presente = pessoaexterna.Presente;
    //        _inserirCommand.Abordagem = pessoaexterna.Abordagem;
    //        _inserirCommand.Status = pessoaexterna.Status;

    //        //return await (GenericCommandResult)handler.Handle(command);
    //        return (GenericCommandResult)_handler.Handle(_inserirCommand);
    //    }

    //    public GenericCommandResult UsuarioPessoaExterna_Alterar(Sessao sessao, UsuarioPessoaExternaAlterarInput pessoaexterna)
    //    {
    //        _alterarCommand.Id = pessoaexterna.Id;
    //        _alterarCommand.Imagem = pessoaexterna.Imagem;
    //        _alterarCommand.Nome = pessoaexterna.Nome;
    //        _alterarCommand.Grupo = pessoaexterna.Grupo;
    //        _alterarCommand.TelefoneFixo = pessoaexterna.TelefoneFixo;
    //        _alterarCommand.TelefoneMovel = pessoaexterna.TelefoneMovel;
    //        _alterarCommand.Email = pessoaexterna.Email;
    //        _alterarCommand.Observacao = pessoaexterna.Observacao;
    //        _alterarCommand.PessoaDocTipo = pessoaexterna.PessoaDocTipo;
    //        _alterarCommand.DocumentoNumero = pessoaexterna.DocumentoNumero;
    //        _alterarCommand.Nascimento = pessoaexterna.Nascimento;
    //        _alterarCommand.EmpresaId = pessoaexterna.EmpresaId;
    //        _alterarCommand.EmpresaNome = pessoaexterna.EmpresaNome;
    //        _alterarCommand.Complemento1 = pessoaexterna.Complemento1;
    //        _alterarCommand.Complemento2 = pessoaexterna.Complemento2;
    //        _alterarCommand.Complemento3 = pessoaexterna.Complemento3;
    //        _alterarCommand.Complemento4 = pessoaexterna.Complemento4;
    //        _alterarCommand.EnderecoLogradouro = pessoaexterna.EnderecoLogradouro;
    //        _alterarCommand.EnderecoNumero = pessoaexterna.EnderecoNumero;
    //        _alterarCommand.EnderecoComplemento = pessoaexterna.EnderecoComplemento;
    //        _alterarCommand.EnderecoBairro = pessoaexterna.EnderecoBairro;
    //        _alterarCommand.EnderecoCep = pessoaexterna.EnderecoCep;
    //        _alterarCommand.EnderecoCidade = pessoaexterna.EnderecoCidade;
    //        _alterarCommand.EnderecoEstado = pessoaexterna.EnderecoEstado;
    //        _alterarCommand.EnderecoPais = pessoaexterna.EnderecoPais;
    //        _alterarCommand.ContratacaoInicio = pessoaexterna.ContratacaoInicio;
    //        _alterarCommand.IntegracaoInicio = pessoaexterna.IntegracaoInicio;
    //        _alterarCommand.ContratacaoFim = pessoaexterna.ContratacaoFim;
    //        _alterarCommand.IntegracaoFim = pessoaexterna.IntegracaoFim;
    //        _alterarCommand.SegurancaInicio = pessoaexterna.SegurancaInicio;
    //        _alterarCommand.SegurancaFim = pessoaexterna.SegurancaFim;
    //        _alterarCommand.ExameMedicoInicio = pessoaexterna.ExameMedicoInicio;
    //        _alterarCommand.ExameMedicoFim = pessoaexterna.ExameMedicoFim;
    //        _alterarCommand.IgnorarBiometria = pessoaexterna.IgnorarBiometria;
    //        _alterarCommand.UltimaVisitaDataHora = pessoaexterna.UltimaVisitaDataHora;
    //        _alterarCommand.UltimoVisitadoId = pessoaexterna.UltimoVisitadoId;
    //        _alterarCommand.UltimoMotivo = pessoaexterna.UltimoMotivo;
    //        _alterarCommand.ExPessoaInterna = pessoaexterna.ExPessoaInterna;
    //        _alterarCommand.DataCadastro = pessoaexterna.DataCadastro;
    //        _alterarCommand.OrigemCadastro = pessoaexterna.OrigemCadastro;
    //        _alterarCommand.Presente = pessoaexterna.Presente;
    //        //_alterarCommand.Abordagem = pessoaexterna.Abordagem;
    //        _alterarCommand.Status = pessoaexterna.Status;

    //        return (GenericCommandResult)_handler.Handle(_alterarCommand);
    //    }

    //    public GenericCommandResult UsuarioPessoaExterna_Excluir(Sessao sessao, int id)
    //    {
    //        _excluirCommand.Id = id;

    //        return (GenericCommandResult)_handler.Handle( _excluirCommand);
    //    }
    //}
}