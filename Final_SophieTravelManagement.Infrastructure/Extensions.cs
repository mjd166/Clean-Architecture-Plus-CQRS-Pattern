using Final_SophieTravelManagement.Application.Services;
using Final_SophieTravelManagement.Infrastructure.EF;
using Final_SophieTravelManagement.Infrastructure.Services;
using Final_SophieTravelManagement.Shared.Queries;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Final_SophieTravelManagement.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSQLDb(configuration);
            services.AddQueries();
            services.AddSingleton<IWeatherService, DumbWeatherService>();
            return services;
        }
    }
}
