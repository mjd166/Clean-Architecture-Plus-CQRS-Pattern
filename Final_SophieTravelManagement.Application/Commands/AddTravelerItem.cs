using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System;

namespace Final_SophieTravelManagement.Application.Commands
{
    public record AddTravelerItem(Guid TravelerCheckListId ,string Name,uint Quantity):ICommand;
}
