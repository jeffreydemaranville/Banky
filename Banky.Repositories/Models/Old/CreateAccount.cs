namespace Banky.Repositories.Models
{
    public class CreateAccount
    {
        public int CustomerId { get; set; }
        public double InitialDeposit { get; set; }
        public short AccountTypeId { get; set; }
    }
}
