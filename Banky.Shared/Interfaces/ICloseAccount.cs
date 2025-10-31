using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky.Shared.Interfaces
{
    public interface ICloseAccount
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
    }
}
