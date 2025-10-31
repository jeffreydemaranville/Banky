using Banky.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky.Repositories.Interfaces
{
    public interface IBankAccountRepository
    {
        Task<AccountDetail> DepositFunds(AccountDetail account, double amount);
        Task<AccountDetail> GetAccountDetails(int accountId, int customerId);
    }
}
