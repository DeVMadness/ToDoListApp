using DAL.Context;
using System.Net;
using System.Net.Http.Headers;
using AutoMapper;
using Domain.Models;
using DAL.MappingProfiles;
using DAL.Repositories.Abstraction;
using DAL.Repositories.Implementation;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<DomainToEntityMappingProfile>();
                cfg.AddProfile<EntityToDomainMappingProfile>();
            });
            IMapper mapper = config.CreateMapper();

            var context = new ToDoListContext();

            



      

            IAssignmentRepository assignment = new AssignmentRepository(context, mapper);



            var asssss = assignment.GetAssignmentsByStatusAsync(1);



            Console.ReadLine();

        }
    }
}
