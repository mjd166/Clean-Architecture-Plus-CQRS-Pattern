using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;

namespace Final_SophieTravelManagement.Domain.Exceptions
{
    public class TravelerCheckListNameException : TravelerCheckListException
    {
        public TravelerCheckListNameException() : base("Traveler Check List Name cannot be empty.")
        {

        }
    }

    public class TravelerItemNotFoundException : TravelerCheckListException
    {
        public string ItemName { get; }

        public TravelerItemNotFoundException(string itemname):base($"Traveler item '{itemname}' not found.")
        {
            ItemName = itemname;
        }
    }
}
