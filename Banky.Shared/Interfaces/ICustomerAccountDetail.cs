namespace Banky.Shared.Interfaces
{
    public interface ICustomerAccountDetail : ICustomerAccount
    {
        public short AccountTypeId { get; set; }
        public short AccountStatusId { get; set; }
        public double Balance { get; set; }
    }
}
