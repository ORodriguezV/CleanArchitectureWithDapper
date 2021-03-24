using CleanArchitectureWithDapper.Infrastructure.UnitOfWork_Inf;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureWithDapper.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
