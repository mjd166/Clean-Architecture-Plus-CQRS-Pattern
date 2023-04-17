﻿using Final_SophieTravelManagement.Domain.Entities;
using Final_SophieTravelManagement.Domain.ValueObjects;
using Final_SophieTravelManagement.Shared.Abstractions.Domain;

namespace Final_SophieTravelManagement.Domain.Events
{
    public record TravelerItemTaken(TravelerCheckList travelerCheckList,TravelerCheckListItem travelerCheckListItem):IDomainEvent;
    
}
