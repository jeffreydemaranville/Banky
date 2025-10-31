using Banky.Shared.Interfaces;

namespace Banky.Services.Models
{
    public class AccountDepositResult : IAccountTransactionResult
    {
        public bool Succeeded { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public double Balance { get; set; }
    }
}
