using Final_SophieTravelManagement.Application.DTO;
using Final_SophieTravelManagement.Infrastructure.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Infrastructure.EF.Queries
{
    public static class Extensions
    {
        public static TravelerCheckListDto AsDto(this TravelerCheckListReadModel readModel)
        => new()
        {
            Id = readModel.Id,
            Name = readModel.Name,
            Destination = new DestinationDto
            {
                City = readModel.Destination?.City,
                Country = readModel.Destination?.Country
            },
            Items = (readModel.Items?.Select(i => new TravelerItemDto
            {
                Name = i.Name,
                Quantity = i.Quantity,
                IsTaken = i.IsTaken
            }))
        };
    }
}
