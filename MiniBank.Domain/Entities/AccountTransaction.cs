using MiniBank.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Domain.Entities
{
    public class AccountTransaction: BaseEntity
    {
        public decimal Amount  { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

        public Guid AccountId { get; set; }
        public virtual Account? Account { get; set; }

    }
}

