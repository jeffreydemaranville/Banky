namespace Banky.Shared.Interfaces
{
    public interface IAccountTransactionResult
    {
        public bool Succeeded { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public double Balance { get; set; }
    }
}
