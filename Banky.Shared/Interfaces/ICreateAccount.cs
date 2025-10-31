using Banky.Shared.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky.Shared.Interfaces
{
    public interface ICreateAccount
    {
        public int CustomerId { get; set; }
        public double InitialDeposit { get; set; }
        public AccountTypeEnum AccountTypeId { get; set; }
    }
}
