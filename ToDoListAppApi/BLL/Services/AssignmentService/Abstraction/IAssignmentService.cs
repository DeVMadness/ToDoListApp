using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AssignmentService.Abstraction
{
    public interface IAssignmentService
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
