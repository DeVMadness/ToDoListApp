using BLL.Services.AssignmentService.Abstraction;
using DAL.Repositories.Abstraction;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AssignmentService.Implementation
{
    public class AssignmentService : IAssignmentService
    {
        private readonly IAssignmentRepository _assignmentRepository;


        public AssignmentService(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public async Task ChangeAssignmentStatusAsync(int currentId, int newStatusId)
        {
            await _assignmentRepository.ChangeAssignmentStatusAsync(currentId, newStatusId);
        }

        public async Task<Assignment> CreateAssignmentAsync(Assignment assignmet)
        {
            return await _assignmentRepository.CreateAssignmentAsync(assignmet);
        }

        public Task DeleteAssignmentById(int id)
        {
            return _assignmentRepository.DeleteAssignmentById(id);
        }

        public async Task<List<Assignment>> GetAllAssignmentsAsync()
        {
            return await _assignmentRepository.GetAllAssignmentsAsync();
        }

        public async Task<Assignment> GetAssignmentByIdAsync(int id)
        {
            return await _assignmentRepository.GetAssignmentByIdAsync(id);
        }

        public async Task<List<Assignment>> GetAssignmentsByStatusAsync(int statusId)
        {
            return await _assignmentRepository.GetAssignmentsByStatusAsync(statusId);
        }

        public Task<Assignment> UpdateAssignmentAsync(int id, Assignment assignment) 
            => _assignmentRepository.UpdateAssignmentAsync(id, assignment);
    }
}
