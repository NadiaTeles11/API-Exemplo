using Flunt.Validations;

namespace NexcodeControls.Shared.Commands
{
    public interface ICommand : IValidatable
    {
        //Implementando IValidatable, requer que todas as classes que herdam de ICommand tenham que passar pela validação obrigatoriamente. 
    }
}
