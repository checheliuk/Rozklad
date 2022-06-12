using API.Helpers;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static void AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(MappingProfiles));
            services.AddDbContext<DataContext>(options => {
                options.UseNpgsql(config.GetConnectionString("DefaultConnection"));
            });
        }
    }
}