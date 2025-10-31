using Banky.Services.Models;
using Banky.Shared.Interfaces;

namespace Banky.Services.Interfaces
{
    public interface IBankAccountService
    {
        Task<IAccountTransactionResult> DepositFunds(AccountDeposit deposit);
        Task<IAccountTransactionResult> WithdrawFunds(AccountWithdrawal withdrawal);
        Task<ICreateAccountResult> CreateAccount(CreateAccount account);
        Task<ICloseAccountResult> CloseAccount(CloseAccount account);
    }
}
