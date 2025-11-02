using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banky.Shared.Interfaces;

namespace Banky.Services.Models
{
    public class CustomerTransactionResult : CustomerAccountResult, ICustomerTransactionResult
    {
        public double Balance { get; set; }
    }
}
