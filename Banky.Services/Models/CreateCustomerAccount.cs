using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banky.Shared.Interfaces;

namespace Banky.Services.Models
{
    public class CreateCustomerAccount : CustomerAccount, ICreateCustomerAccount
    {
        public short AccountTypeId { get; set; }
        public double InitialDeposit { get; set; }
    }
}
