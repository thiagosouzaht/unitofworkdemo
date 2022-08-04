using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UnitOfWorkRestApi.Data.Persistence.Configuration
{
    public static class DbConfiguration
    {
        public static void AddDbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("db");

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
