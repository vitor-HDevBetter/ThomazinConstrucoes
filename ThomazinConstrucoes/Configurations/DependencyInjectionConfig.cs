using Microsoft.AspNetCore.Mvc.DataAnnotations;
using ThomazinConstrucoes.Data;
using ThomazinConstrucoes.Data.Data;

namespace ThomazinConstrucoes.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();

            return services;
        }
    }
}