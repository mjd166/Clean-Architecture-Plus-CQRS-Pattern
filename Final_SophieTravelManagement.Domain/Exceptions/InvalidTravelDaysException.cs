using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;

namespace Final_SophieTravelManagement.Domain.Exceptions
{
    public class InvalidTravelDaysException : TravelerCheckListException
    {
        public ushort Days { get; }

        public InvalidTravelDaysException(ushort days):base($"Days '{days}' value is invalid.")
        {
            Days = days;
        }
    }
}
