using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Domain.Common
{
    public  class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastModified { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
