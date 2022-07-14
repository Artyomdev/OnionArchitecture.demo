using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
namespace Application
{
    public static class ServiceRegistiration
    {
        public static void AddApplicationRegistiration(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();
            services.AddMediatR(assm);
            services.AddAutoMapper(assm);
        }
    }
}
