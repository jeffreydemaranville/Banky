namespace Banky.Shared.Interfaces
{
    public interface ICreateCustomerAccountResult : ICustomerTransactionResult
    {
        public short AccountTypeId { get; set; }
    }
}
