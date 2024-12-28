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

            var ass = context.Assignments.ToList();



            var assign1 = new Assignment
            {
                Title = "Pitu Spatu",
                Description = "First Priority",
                StatusId = 3,
                CreatedAt = DateTime.Now,
            };

            IAssignmentRepository assignment = new AssignmentRepository(context, mapper);


            assignment.CreateAssignmentAsync(assign1);



            Console.ReadLine();

        }
    }
}
