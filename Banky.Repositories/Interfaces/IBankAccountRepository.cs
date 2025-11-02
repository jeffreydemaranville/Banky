using Banky.Repositories.Models;
using Banky.Shared.Interfaces;

namespace Banky.Repositories.Interfaces
{
    public interface IBankAccountRepository
    {
        Task<ICustomerAccountDetail> GetAccountDetails(int accountId, int customerId);
        Task<CustomerDetail> GetCustomerDetails(int customerId);
        Task<ICustomerAccountDetail> DepositFunds(ICustomerAccountDetail account, double amount);
        Task<ICustomerAccountDetail> WithdrawFunds(ICustomerAccountDetail account, double amount);
        Task<ICustomerAccountDetail> CreateCustomerAccount(ICreateCustomerAccount account);
        Task<ICustomerAccountDetail> CloseCustomerAccount(CloseAccount account);
    }
}
