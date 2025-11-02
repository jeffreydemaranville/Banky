using Banky.Shared.Enumerations;

namespace Banky.Shared.Interfaces
{
    public interface ICreateAccount
    {
        public int CustomerId { get; set; }
        public double InitialDeposit { get; set; }
        public AccountTypeEnum AccountTypeId { get; set; }
    }
}
