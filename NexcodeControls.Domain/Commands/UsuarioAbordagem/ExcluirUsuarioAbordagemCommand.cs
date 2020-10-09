using Flunt.Notifications;
using Flunt.Validations;
using NexcodeControls.Shared.Commands;
namespace NexcodeControls.Domain.Commands.UsuarioAbordagem
{
    public class ExcluirUsuarioAbordagemCommand : Notifiable, ICommand
    {
        #region Contrutores

        // construtor sem parametros foi criado devido a criação do outro,  porem ele sozinho nunca deve ser criado para que nada de fora altere o que está aqui dentro
        public ExcluirUsuarioAbordagemCommand() { }

        // construtor com parametros facilita os testes, porem não obrigatorio
        public ExcluirUsuarioAbordagemCommand(int id)
        {
            Id = id;
        }

        #endregion

        #region propriedades
        public int Id { get; set; }

        #endregion

        #region Validações
        public void Validate()
        {
            AddNotifications(new Contract()
             .Requires()
             .IsGreaterOrEqualsThan(Id, 1, "Id", "Id deve ser maior que zero")
             );
        }

        #endregion 
    }
}



