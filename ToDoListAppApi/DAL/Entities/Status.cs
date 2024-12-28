using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Status : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
    }
}
