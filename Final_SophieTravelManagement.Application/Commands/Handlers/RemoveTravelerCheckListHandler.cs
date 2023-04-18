using Final_SophieTravelManagement.Application.Exceptions;
using Final_SophieTravelManagement.Domain.Repositories;
using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Commands.Handlers
{
    public class RemoveTravelerCheckListHandler : ICommandHandler<RemoveTravelerCheckList>
    {
        private readonly ITravelerCheckListRepository repository;

        public RemoveTravelerCheckListHandler(ITravelerCheckListRepository repository)
        {
            this.repository = repository;
        }

        public async Task HandleAsync(RemoveTravelerCheckList command)
        {
            var travelerchecklist = await repository.GetAsync(command.id);
            if(travelerchecklist is null)
            {
                throw new TravelerCheckListNotFoundException(command.id);
            }

            await repository.DeleteAsync(travelerchecklist);
        }
    }
}
