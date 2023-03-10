using DentalCare.Domain.Interfaces;
using DentalCare.Infrastructure.Persistance;
using DentalCare.Infrastructure.Repositories;
using DentalCare.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DentalCareDbContext>(options => options.UseSqlServer(
            configuration.GetConnectionString("DentalCare")));

            services.AddScoped<DentalCareSeeder>();
            services.AddScoped<IDentalCareRepository,DentalCareRepository>();
        }
    }
}
