using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Services
{
    public interface ITravelerCheckListReadService
    {
        Task<bool> ExistByNameAsync(string name);
    }
}
