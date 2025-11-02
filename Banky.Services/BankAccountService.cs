using Banky.Repositories.Interfaces;
using Banky.Repositories.Models;
using Banky.Services.Interfaces;
using Banky.Services.Models;
using Banky.Shared.Enumerations;

namespace Banky.Services
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository _bankAccountRepository;

        public BankAccountService(IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }

        public async Task<CustomerTransactionResult> DepositFunds(CustomerTransaction deposit)
        {
            var accountDetails = await _bankAccountRepository.GetAccountDetails(deposit.AccountId, deposit.CustomerId).ConfigureAwait(false);
            var success = false;
            if (accountDetails.CustomerId > 0 && accountDetails.AccountId > 0 && deposit.Amount > 0)
            {
                accountDetails = await _bankAccountRepository.DepositFunds(accountDetails, deposit.Amount).ConfigureAwait(false);
                success = true;
            }

            var result = new CustomerTransactionResult()
            {
                AccountId = success ? accountDetails.AccountId : 0,
                Balance = success ? accountDetails.Balance : 0,
                CustomerId = success ? accountDetails.CustomerId : 0,
                Succeeded = success
            };            
            return result;
        }

        public async Task<CustomerTransactionResult> WithdrawFunds(CustomerTransaction withdrawal)
        {
            var accountDetails = await _bankAccountRepository.GetAccountDetails(withdrawal.AccountId, withdrawal.CustomerId).ConfigureAwait(false);
            var success = false;
            if(accountDetails.CustomerId > 0 && accountDetails.AccountId > 0 && accountDetails.Balance >= withdrawal.Amount && withdrawal.Amount > 0)
            {
                accountDetails = await _bankAccountRepository.WithdrawFunds(accountDetails, withdrawal.Amount).ConfigureAwait(false);
                success = true;
            }

            var result = new CustomerTransactionResult()
            {
                AccountId = success ? accountDetails.AccountId : 0,
                Balance = success ? accountDetails.Balance : 0,
                CustomerId = success ? accountDetails.CustomerId : 0,
                Succeeded = success
            };
            return result;
        }

        public async Task<CreateCustomerAccountResult> CreateAccount(CreateCustomerAccount account)
        {
            var accountDetail = new CreateCustomerAccountResult();
            var customerDetails = await _bankAccountRepository.GetCustomerDetails(account.CustomerId).ConfigureAwait(false);

            if (customerDetails.CustomerId > 0 && account.InitialDeposit >= 100 && account.AccountTypeId > 0)
            {
                var isFirstAccount = customerDetails.CustomerAccounts?.Count() == 0;
                if (!isFirstAccount || (isFirstAccount && account.AccountTypeId == ((short)AccountTypeEnum.Savings)))
                {
                    var newAccount = new Repositories.Models.CreateAccount()
                    {
                        AccountTypeId = (short)account.AccountTypeId,
                        CustomerId = account.CustomerId,
                        InitialDeposit = account.InitialDeposit,
                    };
                    var createResult = await _bankAccountRepository.CreateCustomerAccount(account);
                    accountDetail = new CreateCustomerAccountResult()
                    {
                        AccountId = createResult.AccountId,
                        CustomerId = createResult.CustomerId,
                        AccountTypeId = (short)account.AccountTypeId,
                        Balance = createResult.Balance,
                        Succeeded = true
                    };
                }
            }

            //var result = new CreateCustomerAccountResult()
            //{
            //    AccountId = accountDetail.AccountId,
            //    AccountTypeId = accountDetail.AccountTypeId,
            //    Balance = accountDetail.InitialDeposit,
            //    CustomerId = accountDetail.CustomerId,
            //    Succeeded = success
            //};
            return accountDetail;
        }

        public async Task<CustomerAccountResult> CloseAccount(CustomerAccount account)
        {
            var success = false;
            var accountDetails = await _bankAccountRepository.GetAccountDetails(account.AccountId, account.CustomerId).ConfigureAwait(false);

            if (accountDetails.CustomerId > 0 && accountDetails.AccountId > 0 && accountDetails.Balance == 0)
            {
                var mappedCloseAccountModel = new Repositories.Models.CloseAccount()
                {
                    AccountId = account.AccountId,
                    CustomerId = accountDetails.CustomerId
                };
                accountDetails = await _bankAccountRepository.CloseCustomerAccount(mappedCloseAccountModel).ConfigureAwait(false);
                success = true;
            }

            var result = new CustomerAccountResult()
            {
                AccountId = success ? accountDetails.AccountId : 0,
                CustomerId = success ? accountDetails.CustomerId : 0,
                Succeeded = success
            };

            return result;
        }
    }
}
