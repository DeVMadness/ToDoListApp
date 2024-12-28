using AutoMapper;
using DAL.Context;
using DAL.Repositories.Abstraction;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Implementation
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly ToDoListContext context;
        private readonly IMapper mapper;
        public AssignmentRepository(ToDoListContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task ChangeAssignmentStatusAsync(int currentId, int newStatusId)
        {
            var assignment = await context.Assignments.FindAsync(currentId);

            if (assignment == null)
                throw new KeyNotFoundException($"Assignment with ID {currentId} was not found.");

            assignment.StatusId = newStatusId;
            await context.SaveChangesAsync();
        }

        public async Task<Assignment> CreateAssignmentAsync(Assignment assignmet)
        {
            var createdAssignment = await context.Assignments.AddAsync(mapper.Map<Entities.Assignment>(assignmet));
            await context.SaveChangesAsync();
            return mapper.Map<Assignment>(createdAssignment.Entity);
        }

        public async Task DeleteAssignmentById(int id)
        {
            var assignment = await context.Assignments.FindAsync(id);

            if (assignment != null)
            {
                context.Assignments.Remove(assignment);
                await context.SaveChangesAsync();
            }
            else
                Console.WriteLine("Not Found");
            
        }

        public async Task<List<Assignment>> GetAllAssignmentsAsync()
        {
            var assignments = await context.Assignments.ToListAsync();
            return mapper.Map<List<Assignment>>(assignments);
        }

        public async Task<Assignment> GetAssignmentByIdAsync(int id)
        {
            var assignment = await context.Assignments.FindAsync(id);

            if (assignment != null)
                return mapper.Map<Assignment>(assignment);
            
            throw new KeyNotFoundException($"Assignment with ID {id} was not found.");
        }

        public async Task<List<Assignment>> GetAssignmentsByStatusAsync(int statusId)
        {
            var assignments = await context.Assignments
               .Where(a => a.StatusId == statusId)
               .ToListAsync();

            return mapper.Map<List<Assignment>>(assignments);
        }

        public async Task<Assignment> UpdateAssignmentAsync(int id, Assignment newAssignment)
        {
            var existingAssingment = await context.Assignments.FindAsync(id);

            if (existingAssingment == null)
            {
                throw new KeyNotFoundException($"Assignment with ID {id} was not found.");
            }

            existingAssingment.Title = newAssignment.Title;
            existingAssingment.Description = newAssignment.Description;
            existingAssingment.StatusId = newAssignment.StatusId;

            await context.SaveChangesAsync();

            return mapper.Map<Assignment>(existingAssingment);
        }
    }
}
