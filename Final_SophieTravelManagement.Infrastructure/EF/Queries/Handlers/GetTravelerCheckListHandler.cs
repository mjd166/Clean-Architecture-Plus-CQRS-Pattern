using Final_SophieTravelManagement.Application.DTO;
using Final_SophieTravelManagement.Domain.Repositories;
using Final_SophieTravelManagement.Shared.Abstractions.Queries;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Queries.Handlers
{
    public class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelerCheckListDto>
    {
        private readonly ITravelerCheckListRepository _repository;

        public GetTravelerCheckListHandler(ITravelerCheckListRepository repository)
        {
            _repository = repository;
        }

        public async Task<TravelerCheckListDto> HandleAsync(GetTravelerCheckList query)
        {
            var travelerchecklist = await _repository.GetAsync(query.Id);
            //Needs Come Back
            return null;
        }
    }
}
