using Banky.Shared.Enumerations;
using Banky.Shared.Interfaces;

namespace Banky.Services.Models
{
    public class CreateAccount : ICreateAccount
    {
        public int CustomerId { get; set; }
        public double InitialDeposit { get; set; }
        public AccountTypeEnum AccountTypeId { get; set; }
        public AccountStatusEnum AccountStatusId { get; set; }
    }
}
