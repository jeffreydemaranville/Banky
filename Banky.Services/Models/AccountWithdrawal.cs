using Banky.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky.Services.Models
{
    public class AccountWithdrawal : IAccountTransaction
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public double Amount { get; set; }
    }
}
