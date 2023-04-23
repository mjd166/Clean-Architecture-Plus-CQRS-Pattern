using Final_SophieTravelManagement.Domain.ValueObjects;
using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;
namespace Final_SophieTravelManagement.Application.Exceptions
{
    public class MissingDestinationWeatherException : TravelerCheckListException
    {
        public TravelerCheckListDestination Destination { get; }

        public MissingDestinationWeatherException(TravelerCheckListDestination destination)
            :base($"Couldnt fetch weather for Destination '{destination.country}/{destination.city}'.")
        {
            Destination = destination;
        }
    }
}
