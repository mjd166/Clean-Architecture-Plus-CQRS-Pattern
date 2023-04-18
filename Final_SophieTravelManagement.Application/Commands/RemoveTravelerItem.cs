using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System;
namespace Final_SophieTravelManagement.Application.Commands
{
    public record RemoveTravelerItem(Guid TravelerCheckListId,string Name):ICommand;
}
