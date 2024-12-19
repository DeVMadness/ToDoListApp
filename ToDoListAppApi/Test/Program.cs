using DAL.Context;
using DAL.Domain;
using System.Net.Http.Headers;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new ToDoListContext();


            var assignment1 = new Assignment 
            { 
                Title = "Created CRUD opperation" , 
                CreatedAt = DateTime.Now, 
                Description = "Taras loh",
                StatusId = context.Statuses.First(s=>s.Name == "Not Started").Id
            };

            var assignment2 = new Assignment
            {
                Title = "Build ToDo App",
                Description = "Create a simple ToDo application using EF Core.",
                StatusId = context.Statuses.First(s => s.Name == "In Progress").Id,
                CreatedAt = DateTime.UtcNow
            };

            var assignment3 = new Assignment
            {
                Title = "Test ToDo App",
                Description = "Test the ToDo application for bugs.",
                StatusId = context.Statuses.First(s => s.Name == "Completed").Id,
                CreatedAt = DateTime.UtcNow
            };

            context.Assignments.AddRange(assignment1, assignment2, assignment3);
            context.SaveChanges();

        }
    }
}
