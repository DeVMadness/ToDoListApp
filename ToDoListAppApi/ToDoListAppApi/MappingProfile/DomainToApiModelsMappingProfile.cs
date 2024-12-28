using AutoMapper;

namespace WebApi.MappingProfile
{
    public class DomainToApiModelsMappingProfile : Profile
    {
        public DomainToApiModelsMappingProfile()
        {
            CreateMap<Domain.Models.Assignment, Models.AssignmentResponse>();
            CreateMap<Domain.Models.Status, Models.StatusResponse>();
        }
    }
}
