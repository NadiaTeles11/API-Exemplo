using Flunt.Notifications;
using Flunt.Validations;
using NC.Shared.Commands;

namespace NC.Domain.Commands.PessoaExterna
{
    //O comando é uma ação que vamos executar

    public class ExcluirPessoaExternaCommand : Notifiable, ICommand
    {      
        #region Contrutores

        // construtor sem parametros foi criado devido a criação do outro,  porem ele sozinho nunca deve ser criado para que nada de fora altere o que está aqui dentro
        public ExcluirPessoaExternaCommand() { }

        // construtor com parametros facilita os testes, porem não obrigatorio
        public ExcluirPessoaExternaCommand(int id)
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
