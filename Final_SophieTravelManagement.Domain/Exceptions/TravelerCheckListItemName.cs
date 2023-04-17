using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;

namespace Final_SophieTravelManagement.Domain.Exceptions
{
    public class TravelerCheckListItemName : TravelerCheckListException
    {
        public TravelerCheckListItemName() : base("Traveler Check List Item name cannot be empty.")
        {

        }
    }
}
