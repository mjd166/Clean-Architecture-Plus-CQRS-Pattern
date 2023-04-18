using Final_SophieTravelManagement.Domain.Consts;
using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System;

namespace Final_SophieTravelManagement.Application.Commands
{
    public record CreateTravelerCheckListWithItems(Guid id,string Name,ushort Days, Gender gender,
        DestinationWriteModel Destination):ICommand;


    public record DestinationWriteModel(string city,string country);
}
