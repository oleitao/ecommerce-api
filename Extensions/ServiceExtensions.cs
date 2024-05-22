﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            { 
            
            });

        public static void ConfigureCors(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });
    }
}
