using Banky.Services.Models;
using Banky.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky.Services.Interfaces
{
    public interface IBankAccountService
    {
        Task<IAccountTransactionResult> DepositFunds(AccountDeposit deposit);
        Task<IAccountTransactionResult> WithdrawFunds(AccountWithdrawal withdrawal);
        Task<ICreateAccountResult> CreateAccount(CreateAccount account);
    }
}
