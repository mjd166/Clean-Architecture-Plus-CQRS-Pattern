using Final_SophieTravelManagement.Domain.ValueObjects;
using System.Collections.Generic;

namespace Final_SophieTravelManagement.Domain.Policies.Gender
{
    internal sealed class FemaleGenderPolicy : ITravelerItemsPolicy
    {


        public bool IsApplicable(PolicyData data) => data.gender is Consts.Gender.Female;



        public IEnumerable<TravelerCheckListItem> GenerateItems(PolicyData data)
        => new List<TravelerCheckListItem>
        {
            new ("Lipstick",1),
            new("powder",1),
            new("eyeliner",1)
        };

       
    }
}
