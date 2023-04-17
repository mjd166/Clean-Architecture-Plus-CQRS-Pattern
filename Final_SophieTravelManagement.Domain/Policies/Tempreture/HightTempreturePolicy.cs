using Final_SophieTravelManagement.Domain.ValueObjects;
using System.Collections.Generic;

namespace Final_SophieTravelManagement.Domain.Policies.Tempreture
{
    internal sealed class HightTempreturePolicy : ITravelerItemsPolicy
    {
        public IEnumerable<TravelerCheckListItem> GenerateItems(PolicyData data)
         => new List<TravelerCheckListItem>
         {
             new("Hat",1),
             new TravelerCheckListItem("Sunglasses",1),
             new("Cream with UV filer",1)
         };

        public bool IsApplicable(PolicyData data)
         => data.tempreture > 25D;
    }
}
