namespace Banky.Repositories.Models
{
    public class CustomerDetail
    {
        public int CustomerId { get; set; }
        public IEnumerable<CustomerAccountDetail> CustomerAccounts { get; set; }
    }
}
