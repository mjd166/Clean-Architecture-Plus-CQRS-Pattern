using Final_SophieTravelManagement.Domain.Exceptions;
namespace Final_SophieTravelManagement.Domain.ValueObjects
{
    public record TravelerCheckListItem
    {
        public string Name { get; }
        public uint Quantity { get;  }

        public bool IsTaken { get; init; }

        public TravelerCheckListItem(string name, uint quantity, bool isTaken=false)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new TravelerCheckListItemName();
            }
            Name = name;
            Quantity = quantity;
            IsTaken = isTaken;
        }
    }
}
