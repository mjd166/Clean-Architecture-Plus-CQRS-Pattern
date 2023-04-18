using Final_SophieTravelManagement.Domain.ValueObjects;
using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;
using System;
namespace Final_SophieTravelManagement.Application.Exceptions
{
    public class TravelerCheckListNotFoundException:TravelerCheckListException
    {
        public Guid Id { get; }
        public TravelerCheckListNotFoundException(Guid id) : base($"Traveler Check List With Id: '{id}' Not Found.")
        => this.Id = id;
    }

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
