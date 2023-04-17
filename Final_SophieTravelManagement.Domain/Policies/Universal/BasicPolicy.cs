using Final_SophieTravelManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Final_SophieTravelManagement.Domain.Policies.Universal
{
    internal sealed class BasicPolicy : ITravelerItemsPolicy
    {
        private const uint MaximumQuantityOfClothes = 7;
        public bool IsApplicable(PolicyData data)
            => true;

        public IEnumerable<TravelerCheckListItem> GenerateItems(PolicyData data)
        => new List<TravelerCheckListItem>
        {
            new("Pants",Math.Min(data.days,MaximumQuantityOfClothes)),
            new("Socks",Math.Min(data.days,MaximumQuantityOfClothes)),
            new("T-Shirt",Math.Min(data.days,MaximumQuantityOfClothes)),
            new("Trousers", data.days <7 ? 1u :2u),
            new("Shampoo",1),
            new("Toothbrush",1),
            new("Toothpaste",1),
            new("Towel",1),
            new("Bag Pack",1),
            new("Passport",1),
            new("Phone Charger",1)
        };

       
    }
}
