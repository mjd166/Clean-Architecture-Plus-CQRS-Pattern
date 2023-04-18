using Final_SophieTravelManagement.Application.Exceptions;
using Final_SophieTravelManagement.Domain.Repositories;
using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Commands.Handlers
{
    public class RemoveTravelerItemHandler : ICommandHandler<RemoveTravelerItem>
    {
        private readonly ITravelerCheckListRepository repository;

        public RemoveTravelerItemHandler(ITravelerCheckListRepository repository)
        {
            this.repository = repository;
        }

        public async Task HandleAsync(RemoveTravelerItem command)
        {
            var travelercheckinglist = await repository.GetAsync(command.TravelerCheckListId);

            if (travelercheckinglist is null)
                throw new TravelerCheckListNotFoundException(command.TravelerCheckListId);


            travelercheckinglist.RemoveItem(command.Name);

            await repository.UpdateAsync(travelercheckinglist);
        }
    }
}
