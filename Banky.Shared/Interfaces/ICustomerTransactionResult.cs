namespace Banky.Shared.Interfaces
{
    public interface ICustomerTransactionResult : ICustomerAccountResult
    {
        public double Balance { get; set; }
    }
}
