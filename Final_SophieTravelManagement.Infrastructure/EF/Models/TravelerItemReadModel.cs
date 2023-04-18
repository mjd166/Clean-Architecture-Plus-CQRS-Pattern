using System;

namespace Final_SophieTravelManagement.Infrastructure.EF.Models
{
    public class TravelerItemReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public uint Quantity { get; set; }
        public bool IsTaken { get; set; }

        public TravelerCheckListReadModel TravelerCheckList { get; set; }
    }
}
