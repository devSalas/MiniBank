using MiniBank.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Domain.Entities
{
    public class Account: BaseEntity
    {
        public string AccountNumber { get; set; } = string.Empty;
        public string Currency { get; set; } = "USD";

        public decimal Balance { get; private set; }

        public Guid CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }

        public virtual ICollection<AccountTransaction> Transactions { get; set; } = new List<AccountTransacction>();

        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
            }
            Balance += amount;

        }

        public void Withdraw(decimal amount)
        {
            if(amount <=0) throw new Exception("Withdraw amount must be positive.");
            if(Balance - amount < 0) throw new Exception("Insufficient funds for this withdrawal.");
            Balance -= amount;
        }


    }
}
