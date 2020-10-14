using Flunt.Notifications;
using Flunt.Validations;
using NC.Shared.Commands;
namespace NC.Domain.Commands.UsuarioAbordagem
{
    public class InserirUsuarioAbordagemCommand : Notifiable, ICommand
    {
        #region Contrutores

        // construtor sem parametros foi criado devido a criação do outro,  porem ele sozinho nunca deve ser criado para que nada de fora altere o que está aqui dentro
        public InserirUsuarioAbordagemCommand() { }

        public InserirUsuarioAbordagemCommand(byte tipo, string mensagem)
        {
            Tipo = tipo;
            Mensagem = mensagem;
        }



        // construtor com parametros facilita os testes, porem não obrigatorio


        #endregion

        #region propriedades
        public byte? Tipo { get; set; }
        public string Mensagem { get; set; }



        #endregion

        #region Validações
        public void Validate()
        {
            AddNotifications(new Contract()
               .Requires()
               .HasMaxLen(Mensagem, 1000, "Mensagem", "Mensagem deve ter no maximo 1000 caracteres")

               );
        }

        #endregion 
    }
}



