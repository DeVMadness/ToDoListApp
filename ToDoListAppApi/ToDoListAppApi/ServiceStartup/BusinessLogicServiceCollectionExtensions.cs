using BLL.Services.AssignmentService.Abstraction;
using BLL.Services.AssignmentService.Implementation;

namespace WebApi.ServiceStartup
{
    public static class BusinessLogicServiceCollectionExtensions
    {
        public static IServiceCollection SetupBusinessLogic(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAssignmentService, AssignmentService>();
            //services.AddScoped<IStatusService, StatusService>();

            return services;
        }
    }
}
