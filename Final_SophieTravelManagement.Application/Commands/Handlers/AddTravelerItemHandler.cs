using Final_SophieTravelManagement.Application.Exceptions;
using Final_SophieTravelManagement.Domain.Repositories;
using Final_SophieTravelManagement.Domain.ValueObjects;
using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Commands.Handlers
{
    public class AddTravelerItemHandler : ICommandHandler<AddTravelerItem>
    {
        private readonly ITravelerCheckListRepository _repository;

        public AddTravelerItemHandler(ITravelerCheckListRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(AddTravelerItem command)
        {
            var travelerCheckingList = await _repository.GetAsync(command.TravelerCheckListId);
            if (travelerCheckingList is null)
            {
                throw new TravelerCheckListNotFoundException(command.TravelerCheckListId);
            }
            var traveleritem = new TravelerCheckListItem(command.Name, command.Quantity);
            travelerCheckingList.AddItem(traveleritem);
            await _repository.UpdateAsync(travelerCheckingList);
        }
    }
}
