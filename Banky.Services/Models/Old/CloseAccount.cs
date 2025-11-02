using Banky.Shared.Interfaces;

namespace Banky.Services.Models
{
    public class CloseAccount : ICloseAccount
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
    }
}
