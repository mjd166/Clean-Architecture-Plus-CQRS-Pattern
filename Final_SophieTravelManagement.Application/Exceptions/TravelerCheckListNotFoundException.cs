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
}
