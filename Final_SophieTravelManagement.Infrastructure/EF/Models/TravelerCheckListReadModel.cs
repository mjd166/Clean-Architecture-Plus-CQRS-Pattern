using System;
using System.Collections.Generic;

namespace Final_SophieTravelManagement.Infrastructure.EF.Models
{
    public class TravelerCheckListReadModel
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public DestinationReadModel Destination { get; set; }
        public ICollection<TravelerItemReadModel> Items { get; set; }

    }
}
