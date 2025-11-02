namespace Banky.Shared.Interfaces
{
    public interface ICloseAccountResult
    {
        public bool Succeeded { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
    }
}
