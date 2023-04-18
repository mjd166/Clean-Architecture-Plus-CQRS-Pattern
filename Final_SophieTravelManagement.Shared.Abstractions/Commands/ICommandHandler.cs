using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Shared.Abstractions.Commands
{
    public interface ICommandHandler<in TCommand> where TCommand :class,ICommand
    {
        Task HandleAsync(TCommand command);
    }
}
