using AutoMapper;
using WebApi.Models;

namespace WebApi.MappingProfile
{
    public class DomainToApiModelsMappingProfile : Profile
    {
        public DomainToApiModelsMappingProfile()
        {
            CreateMap<Domain.Models.Assignment, Models.AssignmentResponse>();
            CreateMap<Domain.Models.Status, Models.StatusResponse>();
            CreateMap<Models.AssignmentRequest, Domain.Models.Assignment>();
            CreateMap<Models.StatusRequest, Domain.Models.Status>();
        }
    }
}
