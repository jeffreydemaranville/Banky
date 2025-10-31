namespace Banky.Shared.Interfaces
{
    public interface ICloseAccount
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
    }
}
