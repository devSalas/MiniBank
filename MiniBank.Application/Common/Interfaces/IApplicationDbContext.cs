using Microsoft.EntityFrameworkCore;
using MiniBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get; }
        DbSet<Account> Accounts { get; }

        DbSet<AccountTransaction> Transactions { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
