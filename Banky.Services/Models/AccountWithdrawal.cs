using Banky.Shared.Interfaces;

namespace Banky.Services.Models
{
    public class AccountWithdrawal : IAccountTransaction
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public double Amount { get; set; }
    }
}
