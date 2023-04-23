using Final_SophieTravelManagement.Application.DTO;
using Final_SophieTravelManagement.Infrastructure.EF.Contexts;
using Final_SophieTravelManagement.Infrastructure.EF.Models;
using Final_SophieTravelManagement.Infrastructure.EF.Queries;
using Final_SophieTravelManagement.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Queries.Handlers
{
    public class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelerCheckListDto>
    {
        private readonly DbSet<TravelerCheckListReadModel> _travelerCheckLists;

        public GetTravelerCheckListHandler(ReadDbContext context)
        {
            _travelerCheckLists = context.TravelerCheckList;
        }

        public async Task<TravelerCheckListDto> HandleAsync(GetTravelerCheckList query)
        => await _travelerCheckLists
            .Include(p => p.Items)
            .Where(p => p.Id == query.Id)
            .Select(p => p.AsDto())
            .AsNoTracking()
            .SingleOrDefaultAsync();
    }
}
