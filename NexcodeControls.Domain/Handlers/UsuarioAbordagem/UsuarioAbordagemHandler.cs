using Flunt.Notifications;
using NexcodeControls.Domain.Commands;
using NexcodeControls.Domain.Commands.UsuarioAbordagem;
using NexcodeControls.Domain.Entities;
using NexcodeControls.Domain.Entities.UsuarioAbordagem;
using NexcodeControls.Domain.Repositories.UsuarioAbordagem;
using NexcodeControls.Shared.Commands;
using NexcodeControls.Shared.Handlers;

namespace NexcodeControls.Domain.Handlers
{
    public class UsuarioAbordagemHandler :
        Notifiable,
        IHandler<InserirUsuarioAbordagemCommand>,
        IHandler<AlterarUsuarioAbordagemCommand>,
        IHandler<ExcluirUsuarioAbordagemCommand>
    {

        private readonly IUsuarioAbordagemRepository _repository;
        public UsuarioAbordagemHandler(IUsuarioAbordagemRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(InserirUsuarioAbordagemCommand command)
        {
            //Fail Fast Validations
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new GenericCommandResult(false, "Não foi possivel realizar o cadastro", MensagemTipo.ERRO, command.Notifications);
            }

            //Verificar se o UsuarioAbordagem esta cadastrado
            //NcUsuarioAbordagem usuarioAbordagem = _repository.ObterPorId(command.UsuarioTipo, command.UsuarioId);
            //if (usuarioAbordagem != null && usuarioAbordagem.Id > 0)
            //{
            //    //AddNotification("Documento", "Este documento já está em uso");
            //    return new GenericCommandResult(false, "Abordagem já está em uso", MensagemTipo.ADVERTENCIA, null);
            //}

            //Checar as notificações
            if (Invalid)
                return new GenericCommandResult(false, "Não foi possível realizar o cadastro", MensagemTipo.ERRO, command.Notifications);

            // Gerar a Área
            var UsuarioAbordagem = new NcUsuarioAbordagem(
                command.Tipo,
                command.Mensagem);

            // Salva no banco            
            _repository.Inserir(UsuarioAbordagem);

            // Retorna o resultado
            return new GenericCommandResult(true, "Cadastro realizado com sucesso", MensagemTipo.INFORMATIVA, UsuarioAbordagem);
        }

        public ICommandResult Handle(AlterarUsuarioAbordagemCommand command)
        {
            //Fail Fast Validations
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new GenericCommandResult(false, "Não foi possivel alterar o cadastro", MensagemTipo.ERRO, command.Notifications);
            }

            //Verificar se a área esta cadastrada
            //NcUsuarioAbordagem UsuarioAbordagem = _repository.ObterPorUsuarioTipo(command.UsuarioTipo, command.Id);
            //if (UsuarioAbordagem != null && UsuarioAbordagem.Id > 0 && command.Id != UsuarioAbordagem.Id)
            //{
            //    //AddNotification("Documento", "Este documento já está em uso");
            //    return new GenericCommandResult(false, "Abordagem já está em uso", MensagemTipo.ADVERTENCIA, null);
            //}

            //Checar as notificações
            if (Invalid)
                return new GenericCommandResult(false, "Não foi possivel alterar o cadastro", MensagemTipo.ERRO, command.Notifications);

            //Obtem o cadastro pelo id
            NcUsuarioAbordagem UsuarioAbordagem = _repository.ObterPorId(command.Id);

            if (UsuarioAbordagem == null)
            {
                return new GenericCommandResult(false, "Não foi possível alterar o cadastro. Cadastro não localizado", MensagemTipo.ADVERTENCIA, null);
            }
            else
            {
                UsuarioAbordagem.Alterar(
                        command.Tipo,
                        command.Mensagem
                    );
            }

            // Salva no banco            
            _repository.Alterar(UsuarioAbordagem);

            // Retorna o resultado
            return new GenericCommandResult(true, "Cadastro alterado com sucesso", MensagemTipo.INFORMATIVA, UsuarioAbordagem);
        }

        public ICommandResult Handle(ExcluirUsuarioAbordagemCommand command)
        {
            //Fail Fast Validations
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new GenericCommandResult(false, "Não foi possivel excluir o cadastro", MensagemTipo.ERRO, command.Notifications);
            }

            //Obtem o cadastro pelo id
            var UsuarioAbordagem = _repository.ObterPorId(command.Id);

            if (UsuarioAbordagem != null && UsuarioAbordagem.Id > 0)
            {
                // Salva no banco            
                _repository.Excluir(UsuarioAbordagem);
            }
            else
            {
                return new GenericCommandResult(false, "Não foi possível excluir o cadastro. Cadastro não localizado", MensagemTipo.ADVERTENCIA, null);
            }

            // Retorna o resultado
            return new GenericCommandResult(true, "Cadastro excluído com sucesso", MensagemTipo.INFORMATIVA, null);
        }

    }
}



