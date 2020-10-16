using Flunt.Notifications;
using NC.Domain.Commands;
using NC.Domain.Commands.PessoaExterna;
using NC.Domain.Entities;
using NC.Domain.Repositories;
using NC.Shared.Commands;
using NC.Shared.Handlers;

namespace NC.Domain.Handlers
{
    public class PessoaExternaHandler :
        Notifiable,
        IHandler<InserirPessoaExternaCommand>,
        IHandler<AlterarPessoaExternaCommand>,
        IHandler<ExcluirPessoaExternaCommand>       
    {

        private readonly IPessoaExternaRepository _repository;     
       

        public PessoaExternaHandler(IPessoaExternaRepository repository) 
        {
            _repository = repository;         
        }
      
        public ICommandResult Handle(InserirPessoaExternaCommand command)
        {
            //Fail Fast Validations
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new GenericCommandResult(false, "Não foi possivel realizar o cadastro", MensagemTipo.ADVERTENCIA, command.Notifications);
            }

            #region Validações       

            //Verificar se email esta cadastrado
            NcPessoaExterna pessoa = _repository.ObterPorEmail(command.Email);
            if (pessoa != null && pessoa.Id > 0)
            {
                //AddNotification("Email", "Este Email já está em uso");
                return new GenericCommandResult(false, "Este e-mail já está em uso", MensagemTipo.ADVERTENCIA, null);
            }

            //Verificar se documento esta cadastrado
            pessoa = _repository.ObterPorDocumentoTipo(command.DocumentoNumero, command.PessoaDocTipo);

            if (pessoa != null && pessoa.Id > 0)
            {
                //AddNotification("Documento", "Este documento já está em uso");
                return new GenericCommandResult(false, "Este documento já está em uso", MensagemTipo.ADVERTENCIA, null);
            }


            #endregion

            //Checar as notificações
            if (Invalid)
                return new GenericCommandResult(false, "Não foi possível realizar o cadastro", MensagemTipo.ADVERTENCIA, command.Notifications);

            //Gerar os VOs
            //var nome = new Nomes(command.Nome);
            //var email = new Email(command.Email);
            //var documento = new NcDocumentoGrupo();
            //var grupo = new NcPessoaGrupo();
            //var visitado = new NcPessoaInterna();

            // Gera a PessoaExterna
            var pessoaExterna = new NcPessoaExterna(               
                command.Nome,
                command.Grupo,
                command.TelefoneFixo                    
                );

            // Salva no banco            
            _repository.Inserir(pessoaExterna);


            // Retorna o resultado
            return new GenericCommandResult(true, "Cadastro realizado com sucesso", MensagemTipo.ADVERTENCIA, null);
        }

        public ICommandResult Handle(AlterarPessoaExternaCommand command)
        {
            //Fail Fast Validations
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new GenericCommandResult(false, "Não foi possivel alterar o cadastro", MensagemTipo.ADVERTENCIA, command.Notifications);
            }

            //Verificar se documento esta cadastrado
            NcPessoaExterna pessoa = _repository.ObterPorDocumentoTipo(command.DocumentoNumero, command.PessoaDocTipo);

            if (pessoa != null && pessoa.Id > 0 && command.Id != pessoa.Id)
            {
                //AddNotification("Documento", "Este documento já está em uso");
                return new GenericCommandResult(false, "Este documento já está em uso", MensagemTipo.ADVERTENCIA, null);
            }

            //Checar as notificações
            if (Invalid)
                return new GenericCommandResult(false, "Não foi possível alterar o cadastro", MensagemTipo.ADVERTENCIA, null);

            //Obtem o cadastro pelo id
            pessoa = _repository.ObterPorId(command.Id);

            if (pessoa == null)
            {
                return new GenericCommandResult(false, "Não foi possível alterar o cadastro. Cadastro não localizado", MensagemTipo.ADVERTENCIA, null);
            }
            else
            {
                pessoa.Alterar(               
                command.Nome,
                command.Grupo,
                command.TelefoneFixo
                );
            }
           
             // Salva no banco            
            _repository.Alterar(pessoa);

            // Retorna o resultado
            return new GenericCommandResult(true, "Cadastro alterado com sucesso", MensagemTipo.ADVERTENCIA, pessoa);
        }

        public ICommandResult Handle(ExcluirPessoaExternaCommand command)
        {
            //Fail Fast Validations
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new GenericCommandResult(false, "Não foi possivel excluir o cadastro", MensagemTipo.ADVERTENCIA, command.Notifications);
            }                     
                    
            //Obtem o cadastro pelo id
            var pessoa = _repository.ObterPorId(command.Id);

            if (pessoa != null && pessoa.Id > 0)
            {
                // Salva no banco            
                _repository.Excluir(pessoa);
            }
            else
            {
                return new GenericCommandResult(false, "Não foi possível excluir o cadastro. Cadastro não localizado", MensagemTipo.ADVERTENCIA, null);
            }             

            // Retorna o resultado
            return new GenericCommandResult(true, "Cadastro excluído com sucesso", MensagemTipo.ADVERTENCIA, null);
        }

    }
}
