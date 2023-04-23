using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;
namespace Final_SophieTravelManagement.Application.Exceptions
{
    public class TravelerCheckListAlreadyExistsException : TravelerCheckListException
    {
        public string Name {get; }

        public TravelerCheckListAlreadyExistsException(string name)
            :base($"Traveler check List with name '{name}' already exists.")
        {
            Name = name;
        }
    }
}
