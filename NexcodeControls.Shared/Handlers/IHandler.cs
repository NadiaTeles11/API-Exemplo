using NexcodeControls.Shared.Commands;

namespace NexcodeControls.Shared.Handlers
{
    public interface IHandler<T>  where T : ICommand      //Isso siginifica que manipulação de comando passe por um contrato, no caso ICommand. Isso impedimos a corrupção de codigo
    {
        ICommandResult Handle( T command);
    }
}
