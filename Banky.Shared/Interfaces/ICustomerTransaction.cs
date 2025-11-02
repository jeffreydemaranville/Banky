namespace Banky.Shared.Interfaces
{
    public interface ICustomerTransaction : ICustomerAccount
    {
        // From ICustomerAccount
        //public int CustomerId { get; set; }
        //public int AccountId { get; set; }
        public double Amount { get; set; }
    }
}
