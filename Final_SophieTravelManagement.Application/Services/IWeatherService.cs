using Final_SophieTravelManagement.Application.DTO.External;
using Final_SophieTravelManagement.Domain.ValueObjects;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDto> GetWeatherAsync(TravelerCheckListDestination localization);
    }
}
