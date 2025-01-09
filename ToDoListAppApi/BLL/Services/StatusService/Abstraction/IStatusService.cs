using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.StatusService.Abstraction
{
    public interface IStatusService
    {
        Task<List<Status>> GetAllStatusAsync();

    }
}
