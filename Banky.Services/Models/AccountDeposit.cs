using Banky.Shared.Interfaces;

namespace Banky.Services.Models
{
    public class AccountDeposit : IAccountTransaction
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public double Amount { get; set; }
    }
}
