using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
