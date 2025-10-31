using Banky.Repositories.Interfaces;
using Banky.Services.Interfaces;
using Banky.Services.Models;
using Banky.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky.Services
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository _bankAccountRepository;

        public BankAccountService(IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }

        public async Task<IAccountTransactionResult> DepositFunds(AccountDeposit deposit)
        {
            var accountDetails = await _bankAccountRepository.GetAccountDetails(deposit.AccountId, deposit.CustomerId).ConfigureAwait(false);
            var success = false;
            if (accountDetails.CustomerId > 0 && accountDetails.AccountId > 0 && deposit.Amount > 0)
            {
                accountDetails = await _bankAccountRepository.DepositFunds(accountDetails, deposit.Amount).ConfigureAwait(false);
                success = true;
            }

            var result = new AccountDepositResult()
            {
                AccountId = success ? accountDetails.AccountId : 0,
                Balance = success ? accountDetails.Balance : 0,
                CustomerId = success ? accountDetails.CustomerId : 0,
                Succeeded = success
            };            
            return result;
        }

        public async Task<IAccountTransactionResult> WithdrawFunds(AccountWithdrawal withdrawal)
        {
            var accountDetails = await _bankAccountRepository.GetAccountDetails(withdrawal.AccountId, withdrawal.CustomerId).ConfigureAwait(false);
            var success = false;
            if(accountDetails.CustomerId > 0 && accountDetails.AccountId > 0 && accountDetails.Balance > withdrawal.Amount && withdrawal.Amount > 0)
            {
                accountDetails = await _bankAccountRepository.WithdrawFunds(accountDetails, withdrawal.Amount).ConfigureAwait(false);
                success = true;
            }

            var result = new AccountWithdrawalResult()
            {
                AccountId = success ? accountDetails.AccountId : 0,
                Balance = success ? accountDetails.Balance : 0,
                CustomerId = success ? accountDetails.CustomerId : 0,
                Succeeded = success
            };
            return result;
        }
    }
}
