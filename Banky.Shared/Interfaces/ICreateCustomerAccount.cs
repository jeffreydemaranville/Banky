namespace Banky.Shared.Interfaces
{
    public interface ICreateCustomerAccount
    {
        public int CustomerId { get; set; }
        public short AccountTypeId { get; set; }
        public double InitialDeposit { get; set; }
    }
}
