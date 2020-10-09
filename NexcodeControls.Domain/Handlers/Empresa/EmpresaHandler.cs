using Flunt.Notifications;
using NexcodeControls.Domain.Commands;
using NexcodeControls.Domain.Commands.Entidade;
using NexcodeControls.Domain.Entities;
using NexcodeControls.Domain.Repositories.Entidade;
using NexcodeControls.Shared.Commands;
using NexcodeControls.Shared.Handlers;

namespace NexcodeControls.Domain.Handlers.Entidade
{
    public class EmpresaHandler :
        Notifiable,
        IHandler<InserirEmpresaCommand>,
        IHandler<AlterarEmpresaCommand>,
        IHandler<ExcluirEmpresaCommand>
    {

        private readonly IEmpresaRepository _repository;
        public EmpresaHandler(IEmpresaRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle( InserirEmpresaCommand command)
        {
            //Fail Fast Validations
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new GenericCommandResult(false, "Não foi possivel realizar o cadastro", MensagemTipo.ADVERTENCIA, command.Notifications);
            }

            //Verificar se a Entidade esta cadastrada
            NcEmpresa empresa = _repository.ObterPorNome(command.Nome);
            if (empresa != null && empresa.Id > 0)
            {
                //AddNotification("Documento", "Este documento já está em uso");
                return new GenericCommandResult(false, "Empresa já está em uso", MensagemTipo.ADVERTENCIA, null);
            }

            //Checar as notificações
            if (Invalid)
                return new GenericCommandResult(false, "Não foi possível realizar o cadastro", MensagemTipo.ADVERTENCIA, command.Notifications);

            // Gerar a Entidade
            var Empresa = new NcEmpresa(
                command.Nome,
                command.Grupo,
                command.Gestor,
                command.Telefone1,
                command.Telefone2,
                command.Email,
                command.Cnpj,
                command.Ie,
                command.Complemento1,
                command.Complemento2,
                command.Classificacao,
                command.EnderecoLogradouro,
                command.EnderecoNumero,
                command.EnderecoComplemento,
                command.EnderecoBairro,
                command.EnderecoCep,
                command.EnderecoCidade,
                command.EnderecoEstado,
                command.EnderecoPais,
                command.Observacao,
                command.DataCadastro

                );

            // Salva no banco            
            _repository.Inserir(Empresa);

            // Retorna o resultado
            return new GenericCommandResult(true, "Cadastro realizado com sucesso", MensagemTipo.ADVERTENCIA, Empresa);
        }

        public ICommandResult Handle( AlterarEmpresaCommand command)
        {
            //Fail Fast Validations
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new GenericCommandResult(false, "Não foi possivel alterar o cadastro", MensagemTipo.ADVERTENCIA, command.Notifications);
            }

            //Verificar se a entidade esta cadastrada
            NcEmpresa empresa = _repository.ObterPorNome(command.Nome);
            if (empresa != null && empresa.Id > 0 && command.Id != empresa.Id)
            {
                //AddNotification("Documento", "Este documento já está em uso");
                return new GenericCommandResult(false, "Empresa já está em uso", MensagemTipo.ADVERTENCIA, null);
            }

            //Checar as notificações
            if (Invalid)
                return new GenericCommandResult(false, "Não foi possivel alterar o cadastro", MensagemTipo.ADVERTENCIA, command.Notifications);

            //Obtem o cadastro pelo id
            empresa = _repository.ObterPorId(command.Id);

            if (empresa == null)
            {
                return new GenericCommandResult(false, "Não foi possível alterar o cadastro. Cadastro não localizado", MensagemTipo.ADVERTENCIA, null);
            }
            else
            {
                empresa.Alterar(
                        command.Nome,
                        command.Grupo,
                        command.Gestor,
                        command.Telefone1,
                        command.Telefone2,
                        command.Email,
                        command.Cnpj,
                        command.Ie,
                        command.Complemento1,
                        command.Complemento2,
                        command.Classificacao,
                        command.EnderecoLogradouro,
                        command.EnderecoNumero,
                        command.EnderecoComplemento,
                        command.EnderecoBairro,
                        command.EnderecoCep,
                        command.EnderecoCidade,
                        command.EnderecoEstado,
                        command.EnderecoPais,
                        command.Observacao,
                        command.DataCadastro
                    );
            }

            // Salva no banco            
            _repository.Alterar(empresa);

            // Retorna o resultado
            return new GenericCommandResult(true, "Cadastro alterado com sucesso", MensagemTipo.ADVERTENCIA, empresa);
        }

        public ICommandResult Handle( ExcluirEmpresaCommand command)
        {
            //Fail Fast Validations
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new GenericCommandResult(false, "Não foi possivel excluir o cadastro", MensagemTipo.ADVERTENCIA, command.Notifications);
            }

            //Obtem o cadastro pelo id
            var Empresa = _repository.ObterPorId(command.Id);

            if (Empresa != null && Empresa.Id > 0)
            {
                // Salva no banco            
                _repository.Excluir(Empresa);
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



