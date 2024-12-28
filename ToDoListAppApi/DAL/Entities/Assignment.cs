using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Assignment : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int StatusId { get; set; }

        [ForeignKey(nameof(StatusId))]
        public virtual Status? Status { get; set; }
        public virtual DateTime CreatedAt { get; set; }
    }
}
