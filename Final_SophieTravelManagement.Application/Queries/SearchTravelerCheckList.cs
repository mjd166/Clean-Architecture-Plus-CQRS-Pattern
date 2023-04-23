using Final_SophieTravelManagement.Application.DTO;
using Final_SophieTravelManagement.Shared.Abstractions.Queries;
using System.Collections.Generic;

namespace Final_SophieTravelManagement.Application.Queries
{
    public class SearchTravelerCheckList : IQuery<IEnumerable<TravelerCheckListDto>>
    {
        public string SearchPhrase { get; set; }
    }
}
