using System;
namespace Final_SophieTravelManagement.Application.DTO
{
    public class TravelerCheckListDto
    {
        public Guid  Id { get; set; }
        public string Name { get; set; }
        public DestinationDto Destination { get; set; }
        public IEquatable<TravelerItemDto> Items { get; set; }
    }
}
