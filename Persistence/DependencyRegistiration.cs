using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence
{
    public static class DependencyRegistiration
    {
        public static void AddDependencyRegistiration(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
