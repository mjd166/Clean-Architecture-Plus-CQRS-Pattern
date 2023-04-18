using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System;
namespace Final_SophieTravelManagement.Application.Commands
{
    public record TakeItem(Guid TravelerCheckListId,string Name):ICommand;
}
