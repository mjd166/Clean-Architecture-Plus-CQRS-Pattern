using Final_SophieTravelManagement.Application.Exceptions;
using Final_SophieTravelManagement.Application.Services;
using Final_SophieTravelManagement.Domain.Factories;
using Final_SophieTravelManagement.Domain.Repositories;
using Final_SophieTravelManagement.Domain.ValueObjects;
using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Commands.Handlers
{
    public class CreateTravelerCheckListWithItemsHandler : ICommandHandler<CreateTravelerCheckListWithItems>
    {
        private readonly ITravelerCheckListRepository repository;
        private readonly ITravelerCheckListFactory factory;
        private readonly IWeatherService weatherService;

        public CreateTravelerCheckListWithItemsHandler(ITravelerCheckListRepository repository, ITravelerCheckListFactory factory, IWeatherService weatherService)
        {
            this.repository = repository;
            this.factory = factory;
            this.weatherService = weatherService;
        }

        public async Task HandleAsync(CreateTravelerCheckListWithItems command)
        {
            var (id, name, days, gender, DestinationWriteModel) = command;

            var destination = new TravelerCheckListDestination(DestinationWriteModel.city, DestinationWriteModel.country);
            var weather = await weatherService.GetWeatherAsync(destination);

            if(weather is null)
            {
                throw new MissingDestinationWeatherException(destination);
            }

            var TravelerCheckList = factory.CreateWithDefaultItems(id, name, days, gender, weather.Tempreture, destination);

            await repository.AddAsync(TravelerCheckList);
        }
    }
}
