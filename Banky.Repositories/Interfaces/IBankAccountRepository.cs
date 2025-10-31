using Banky.Repositories.Models;

namespace Banky.Repositories.Interfaces
{
    public interface IBankAccountRepository
    {
        Task<AccountDetail> GetAccountDetails(int accountId, int customerId);
        Task<CustomerDetail> GetCustomerDetails(int customerId);
        Task<AccountDetail> DepositFunds(AccountDetail account, double amount);
        Task<AccountDetail> WithdrawFunds(AccountDetail account, double amount);
        Task<AccountDetail> CreateCustomerAccount(CreateAccount account);
        Task<AccountDetail> CloseCustomerAccount(CloseAccount account);
    }
}
