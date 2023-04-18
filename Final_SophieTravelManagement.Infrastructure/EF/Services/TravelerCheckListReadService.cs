using Final_SophieTravelManagement.Application.Services;
using Final_SophieTravelManagement.Infrastructure.EF.Contexts;
using Final_SophieTravelManagement.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Infrastructure.EF.Services
{
    public class TravelerCheckListReadService : ITravelerCheckListReadService
    {

        private readonly DbSet<TravelerCheckListReadModel> _travelerCheckList;

        public TravelerCheckListReadService(ReadDbContext context)
        => _travelerCheckList = context.TravelerCheckList;


        public Task<bool> ExistByNameAsync(string name)
       => _travelerCheckList.AnyAsync(x => x.Name == name);
    }
}
