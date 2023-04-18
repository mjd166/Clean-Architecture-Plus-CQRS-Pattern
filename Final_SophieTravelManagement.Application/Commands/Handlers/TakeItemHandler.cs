using Final_SophieTravelManagement.Application.Exceptions;
using Final_SophieTravelManagement.Domain.Repositories;
using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Commands.Handlers
{
    public class TakeItemHandler : ICommandHandler<TakeItem>
    {
        private readonly ITravelerCheckListRepository repository;

        public TakeItemHandler(ITravelerCheckListRepository repository)
        {
            this.repository = repository;
        }

        public  async Task HandleAsync(TakeItem command)
        {
            var travelerchekinglist = await repository.GetAsync(command.TravelerCheckListId);

            if (travelerchekinglist is null)
                throw new TravelerCheckListNotFoundException(command.TravelerCheckListId);


            travelerchekinglist.TakeItem(command.Name);

            await repository.UpdateAsync(travelerchekinglist);
        }
    }
}
