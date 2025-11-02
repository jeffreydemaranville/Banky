using Banky.Shared.Interfaces;

namespace Banky.Services.Models
{
    public class CustomerAccountDetail : ICustomerAccountDetail
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public short AccountTypeId { get; set; }
        public short AccountStatusId { get; set; }
        public double Balance { get; set; }
    }
}
