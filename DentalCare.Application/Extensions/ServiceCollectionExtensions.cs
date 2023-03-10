using DentalCare.Application.Services;
using DentalCare.Domain.Entities;
using DentalCare.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
         services.AddScoped<IDentalCareService,DentalCareService>();
        }
    }
}
