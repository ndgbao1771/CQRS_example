using System.Windows.Input;

namespace CQRS_example.Factories.Interfaces
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<TCommand> CreateHandler<TCommand>() where TCommand : ICommand;
    }
}
