namespace Banky.Shared.Interfaces
{
    public interface ICustomerAccountResult : ICustomerAccount // Base
    {
        public bool Succeeded { get; set; }
    }
}
