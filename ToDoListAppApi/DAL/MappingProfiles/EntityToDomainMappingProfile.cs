using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace DAL.MappingProfiles
{
    public class EntityToDomainMappingProfile : Profile
    {
       public EntityToDomainMappingProfile()
       {
            CreateMap<Entities.Assignment, Domain.Models.Assignment>();
            CreateMap<Entities.Status, Domain.Models.Status>();
       }
    }
}
