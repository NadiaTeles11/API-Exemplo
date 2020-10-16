using HotChocolate.Types;
using NC.Api.GraphQL.Mutations.PessoaExterna;
using NC.Domain.Commands;
using NC.Domain.Commands.PessoaExterna;
using NC.Domain.Entities;
using NC.Domain.Handlers;

namespace NC.Api.GraphQL.Mutations
{
    [ExtendObjectType(Name = "Mutation")]
    public class UsuarioPessoaExternaMutation
    {
        private readonly InserirPessoaExternaCommand _inserirCommand;
        private readonly AlterarPessoaExternaCommand _alterarCommand;
        private readonly ExcluirPessoaExternaCommand _excluirCommand;

        private readonly PessoaExternaHandler _handler;
        public UsuarioPessoaExternaMutation(InserirPessoaExternaCommand inserirCommand,
            AlterarPessoaExternaCommand alterarCommand,
            ExcluirPessoaExternaCommand excluirCommand,
            PessoaExternaHandler handler)
        {
            _inserirCommand = inserirCommand;
            _alterarCommand = alterarCommand;
            _excluirCommand = excluirCommand;
            _handler = handler;
        }

        //ok
        //public GenericCommandResult UsuarioPessoaExterna_Inserir(Sessao sessao, UsuarioPessoaExternaInserirInput pessoaexterna)

        //Erro
        public GenericCommandResult UsuarioPessoaExterna_Inserir(Sessao sessao, InserirPessoaExternaCommand pessoaexterna)
        {          
            _inserirCommand.Nome = pessoaexterna.Nome;
            _inserirCommand.Grupo = pessoaexterna.Grupo;
            _inserirCommand.TelefoneFixo = pessoaexterna.TelefoneFixo;
              
            return (GenericCommandResult)_handler.Handle(_inserirCommand);
        }

        public GenericCommandResult UsuarioPessoaExterna_Alterar(Sessao sessao, UsuarioPessoaExternaAlterarInput pessoaexterna)
        {
            _alterarCommand.Id = pessoaexterna.Id;      
            _alterarCommand.Nome = pessoaexterna.Nome;
            _alterarCommand.Grupo = pessoaexterna.Grupo;
            _alterarCommand.TelefoneFixo = pessoaexterna.TelefoneFixo;
           
            return (GenericCommandResult)_handler.Handle(_alterarCommand);
        }

        public GenericCommandResult UsuarioPessoaExterna_Excluir(Sessao sessao, int id)
        {
            _excluirCommand.Id = id;

            return (GenericCommandResult)_handler.Handle(_excluirCommand);
        }
    }
}