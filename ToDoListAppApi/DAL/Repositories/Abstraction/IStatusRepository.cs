using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace DAL.Repositories.Abstraction
{
    public interface IStatusRepository
    {
        public Task<List<Status>> GetAllStatusAsync();
    }
}
