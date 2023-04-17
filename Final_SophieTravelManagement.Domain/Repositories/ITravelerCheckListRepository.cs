using Final_SophieTravelManagement.Domain.Entities;
using Final_SophieTravelManagement.Domain.ValueObjects;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Domain.Repositories
{
    public interface  ITravelerCheckListRepository
    {
        Task<TravelerCheckList> GetAsync(TravelerCheckListId id);
        Task AddAsync(TravelerCheckList travelerCheckList);
        Task UpdateAsync(TravelerCheckList travelerCheckList);
        Task DeleteAsync(TravelerCheckList travelerCheckList);
    }
}
