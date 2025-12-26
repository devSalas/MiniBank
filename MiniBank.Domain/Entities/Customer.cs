using MiniBank.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
}
