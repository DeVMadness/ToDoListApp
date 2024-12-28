using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.MappingProfiles
{
    public class DomainToEntityMappingProfile : Profile
    {
        public DomainToEntityMappingProfile() 
        {
            CreateMap<Domain.Models.Assignment, Entities.Assignment>();
            CreateMap<Domain.Models.Status, Entities.Status>();
        }
    }
}
