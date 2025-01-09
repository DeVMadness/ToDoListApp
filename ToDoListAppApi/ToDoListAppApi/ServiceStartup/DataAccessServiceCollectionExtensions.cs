using DAL.Context;
using DAL.Repositories.Abstraction;
using DAL.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;


namespace WebApi.ServiceStartup
{
    public static class DataAccessServiceCollectionExtensions
    {
        public static IServiceCollection SetupDataAccess(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<ToDoListContext>(options =>
            {
                options.UseSqlServer(@Environment.GetEnvironmentVariable("ToDoListDbConnectionString")).UseLazyLoadingProxies();
            });

            services.AddScoped<IAssignmentRepository, AssignmentRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();

            return services;
        }
    }
}
