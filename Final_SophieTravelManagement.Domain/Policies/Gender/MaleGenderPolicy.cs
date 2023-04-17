using Final_SophieTravelManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Final_SophieTravelManagement.Domain.Policies.Gender
{
    internal sealed class MaleGenderPolicy : ITravelerItemsPolicy
    {

        public bool IsApplicable(PolicyData data) => data.gender is Consts.Gender.Male;

        public IEnumerable<TravelerCheckListItem> GenerateItems(PolicyData data)
        => new List< TravelerCheckListItem>
        {
            new("LapTop",1),
            new TravelerCheckListItem("Drink",10),
            new("Book",(uint) Math.Ceiling(data.days/7m))
        };

       
    }
}
