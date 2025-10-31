namespace Banky.Shared.Interfaces
{
    public interface IAccountTransaction
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public double Amount { get; set; }
    }
}
