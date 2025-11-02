using Banky.Services.Models;

namespace Banky.Services.Interfaces
{
    public interface IBankAccountService
    {
        Task<CustomerTransactionResult> DepositFunds(CustomerTransaction deposit);
        Task<CustomerTransactionResult> WithdrawFunds(CustomerTransaction withdrawal);
        Task<CreateCustomerAccountResult> CreateAccount(CreateCustomerAccount account);
        Task<CustomerAccountResult> CloseAccount(CustomerAccount account);
    }
}
