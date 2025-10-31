namespace Banky.Shared.Interfaces
{
    public interface ICreateAccountResult
    {
        public bool Succeeded { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public short AccountTypeId { get; set; }
        public double Balance { get; set; }
    }
}
