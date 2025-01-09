using BLL.Services.StatusService.Abstraction;
using DAL.Repositories.Abstraction;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.StatusService.Implementation
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository statusRepository;

        public StatusService(IStatusRepository _statusRepository)
        {
            statusRepository = _statusRepository;
        }
        public async Task<List<Status>> GetAllStatusAsync()
        {
            return await statusRepository.GetAllStatusAsync();
        }
    }
}
