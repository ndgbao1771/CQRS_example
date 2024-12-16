using CQRS_example.DataAccess.Implements;
using CQRS_example.DataAccess.Interfaces;

namespace CQRS_example.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentDataAccess, StudentDataAccesss>();
            services.AddScoped<IClassDataAccess, ClassDataAccess>();
        }
    }
}
