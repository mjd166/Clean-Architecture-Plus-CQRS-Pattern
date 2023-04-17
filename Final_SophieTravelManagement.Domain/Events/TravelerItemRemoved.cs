using Final_SophieTravelManagement.Domain.Entities;
using Final_SophieTravelManagement.Domain.ValueObjects;
using Final_SophieTravelManagement.Shared.Abstractions.Domain;

namespace Final_SophieTravelManagement.Domain.Events
{
    public record TravelerItemRemoved(TravelerCheckList travelerCheckList,TravelerCheckListItem travelerCheckListItem):IDomainEvent;
    
}
