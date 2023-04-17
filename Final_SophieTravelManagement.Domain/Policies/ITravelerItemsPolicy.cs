using Final_SophieTravelManagement.Domain.ValueObjects;
using System.Collections.Generic;

namespace Final_SophieTravelManagement.Domain.Policies
{
    public interface ITravelerItemsPolicy
    {
        bool IsApplicable(PolicyData data);
        IEnumerable<TravelerCheckListItem> GenerateItems(PolicyData data);
    }

    public record PolicyData(TravelDays days,Consts.Gender gender,Tempreture tempreture, TravelerCheckListDestination destination);
}
