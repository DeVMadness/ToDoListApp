using DAL.MappingProfiles;
using System.Runtime.CompilerServices;
using WebApi.MappingProfile;

namespace WebApi.ServiceStartup
{
    public static class AutoMapperServiceCollectionExtensions
    {
        public static IServiceCollection SetupAutoMapper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<DomainToEntityMappingProfile>();
                cfg.AddProfile<EntityToDomainMappingProfile>();
                cfg.AddProfile<DomainToApiModelsMappingProfile>();
            });

            return services;
        }
    }
}
    
