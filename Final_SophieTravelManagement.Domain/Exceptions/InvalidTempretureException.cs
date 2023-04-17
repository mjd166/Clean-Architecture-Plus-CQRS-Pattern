using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;

namespace Final_SophieTravelManagement.Domain.Exceptions
{
    public class InvalidTempretureException : TravelerCheckListException
    {
        public double Value { get; }

        public InvalidTempretureException(double value) :base($"Value '{value}' is invalid tempreture.")
        {
            Value = value;
        }
    }
}
