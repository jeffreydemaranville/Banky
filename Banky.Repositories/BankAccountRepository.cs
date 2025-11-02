using Banky.Repositories.Interfaces;
using Banky.Repositories.Models;
using Banky.Shared.Interfaces;

namespace Banky.Repositories
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly List<CustomerAccountDetail> _accountDetailModels;
        private readonly List<CustomerDetail> _customerDetailModels;
        private readonly CustomerAccountDetail _noAccount = new CustomerAccountDetail() { AccountId = 0, CustomerId = 0, Balance = 0, AccountTypeId = 0 };
        private readonly CustomerDetail _noCustomer = new CustomerDetail() { CustomerId = 0, CustomerAccounts = new List<CustomerAccountDetail>() };

        public BankAccountRepository(List<CustomerAccountDetail> accountDetailModels,  List<CustomerDetail> customerDetailModels)
        {
            _accountDetailModels = accountDetailModels;
            _customerDetailModels = customerDetailModels;
        }

        public async Task<ICustomerAccountDetail> GetAccountDetails(int accountId, int customerId)
        {
            var accountDetails = _accountDetailModels.Find(x => x.AccountId == accountId && x.CustomerId == customerId) ?? _noAccount;
            return accountDetails;
        }

        public async Task<CustomerDetail> GetCustomerDetails(int customerId)
        {
            var customerDetails = _customerDetailModels.Find(x => x.CustomerId == customerId) ?? _noCustomer;
            var customerAccounts = _accountDetailModels.Where(x => x.CustomerId == customerId);
            if (customerAccounts != null)
            {
                customerDetails.CustomerAccounts = customerAccounts;
            }
            return customerDetails;
        }

        public async Task<ICustomerAccountDetail> DepositFunds(ICustomerAccountDetail account, double amount)
        {
            account.Balance += amount;
            return account;
        }

        public async Task<ICustomerAccountDetail> WithdrawFunds(ICustomerAccountDetail account, double amount)
        {
            account.Balance -= amount;
            return account;
        }

        public async Task<ICustomerAccountDetail> CreateCustomerAccount(ICreateCustomerAccount account)
        {
            CustomerAccountDetail accountDetail = new CustomerAccountDetail()
            {
                AccountId = _accountDetailModels.Max(x => x.AccountId + 1000),
                AccountStatusId = 1,
                AccountTypeId = account.AccountTypeId,
                Balance = account.InitialDeposit,
                CustomerId = account.CustomerId
            };
            _accountDetailModels.Add(accountDetail);
            return accountDetail;
        }

        public async Task<ICustomerAccountDetail> CloseCustomerAccount(CloseAccount account)
        {
            _accountDetailModels.Find(x => x.CustomerId == account.CustomerId && x.AccountId == account.AccountId).AccountStatusId = 0;
            var accountDetails = _accountDetailModels.Find(x => x.CustomerId == account.CustomerId && x.AccountId == account.AccountId);
            return accountDetails;
        }
    }
}
