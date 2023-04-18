using Final_SophieTravelManagement.Application.DTO;
using Final_SophieTravelManagement.Shared.Abstractions.Queries;
using System;
namespace Final_SophieTravelManagement.Application.Queries
{
    public class SearchTravelerCheckList : IQuery<IEquatable<TravelerCheckListDto>>
    {
        public string SearchPhrase { get; set; }
    }
}
