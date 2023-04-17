using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;

namespace Final_SophieTravelManagement.Domain.Exceptions
{
    public class TravelerItemAlreadyExistException : TravelerCheckListException
    {
        public string ListName { get; }
        public string ItemName { get; }

        public TravelerItemAlreadyExistException(string listName, string itemName)
            :base($"Traveler Check List:'{listName}' already defined '{itemName}'")
        {
            ListName = listName;
            ItemName = itemName;
        }
    }
}
