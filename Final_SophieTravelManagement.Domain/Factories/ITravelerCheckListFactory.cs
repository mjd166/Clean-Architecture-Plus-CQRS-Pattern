using Final_SophieTravelManagement.Domain.Consts;
using Final_SophieTravelManagement.Domain.Entities;
using Final_SophieTravelManagement.Domain.Policies;
using Final_SophieTravelManagement.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace Final_SophieTravelManagement.Domain.Factories
{
    public interface ITravelerCheckListFactory
    {
        TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, TravelerCheckListDestination destination);
        TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender,
            Tempreture tempreture, TravelerCheckListDestination destination);

    }

    public class TravelerCheckListFactory : ITravelerCheckListFactory
    {
        private readonly IEnumerable<ITravelerItemsPolicy> _policies;

        public TravelerCheckListFactory(IEnumerable<ITravelerItemsPolicy> policies)
        {
            _policies = policies;
        }

        public TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, TravelerCheckListDestination destination)
        => new(id, name, destination);

        public TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender, Tempreture tempreture, TravelerCheckListDestination destination)
        {
            var data = new PolicyData(days, gender, tempreture, destination);
            var applicablePolicies = _policies.Where(p => p.IsApplicable(data));

            var items = applicablePolicies.SelectMany(p => p.GenerateItems(data));
            var travelerchekinglist = Create(id, name, destination);

            travelerchekinglist.AddItems(items);

            return travelerchekinglist;
        }
    }
}
