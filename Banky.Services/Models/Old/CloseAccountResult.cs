using Banky.Shared.Interfaces;

namespace Banky.Services.Models
{
    public class CloseAccountResult : ICloseAccountResult
    {
        public bool Succeeded { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
    }
}
