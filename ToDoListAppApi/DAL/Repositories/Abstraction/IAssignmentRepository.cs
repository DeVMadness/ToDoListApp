using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace DAL.Repositories.Abstraction
{
    public interface IAssignmentRepository
    {
        Task<Assignment> CreateAssignmentAsync(Assignment assignmet);
        Task DeleteAssignmentById(int id);
        Task<Assignment> GetAssignmentByIdAsync(int id);
        Task<Assignment> UpdateAssignmentAsync(int id, Assignment assignment);
        Task<List<Assignment>> GetAssignmentsByStatusAsync(int statusId);
        Task<List<Assignment>> GetAllAssignmentsAsync();
        Task ChangeAssignmentStatusAsync(int currentId, int newStatusId);
    }
}
