using Final_SophieTravelManagement.Domain.ValueObjects;
using System.Collections.Generic;

namespace Final_SophieTravelManagement.Domain.Policies.Tempreture
{
    internal sealed class LowTempreturePolicy : ITravelerItemsPolicy
    {
        public IEnumerable<TravelerCheckListItem> GenerateItems(PolicyData data)
         => new List<TravelerCheckListItem>
         {
             new("Winter Hat",1),
             new("Scarf",1),
             new("Gloves",1),
             new("Hoodie",1),
             new("warm jaket",1)
         };

        public bool IsApplicable(PolicyData data)
        => data.tempreture < 10D;
    }
}
