using CleanArchitectureWithDapper.Application.AutoMapper;
using CleanArchitectureWithDapper.Application.Person_App;
using CleanArchitectureWithDapper.Application.Phones_App;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureWithDapper.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddTransient<IPersonBL, PersonBL>();
            services.AddTransient<IPhonesBL, PhonesBL>();
        }
       
    }
}
