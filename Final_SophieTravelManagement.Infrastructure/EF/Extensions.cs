using Final_SophieTravelManagement.Application.Services;
using Final_SophieTravelManagement.Domain.Repositories;
using Final_SophieTravelManagement.Infrastructure.EF.Contexts;
using Final_SophieTravelManagement.Infrastructure.EF.Options;
using Final_SophieTravelManagement.Infrastructure.EF.Repositories;
using Final_SophieTravelManagement.Infrastructure.EF.Services;
using Final_SophieTravelManagement.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Final_SophieTravelManagement.Infrastructure.EF
{
    public static class Extensions
    {
        public static IServiceCollection AddSQLDb(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddScoped<ITravelerCheckListRepository, TravelerCheckListRepository>();
            services.AddScoped<ITravelerCheckListReadService, TravelerCheckListReadService>();

            var options = configuration.GetOptions<DataBaseOptions>("DataBaseConnectionString");
            services.AddDbContext<ReadDbContext>(c =>
            c.UseSqlServer(options.ConnectionString));

            services.AddDbContext<WriteDbContext>(c =>
            c.UseSqlServer(options.ConnectionString));

            return services;
        }
    }
}
