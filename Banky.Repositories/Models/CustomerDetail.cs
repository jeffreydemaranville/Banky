using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky.Repositories.Models
{
    public class CustomerDetail
    {
        public int CustomerId { get; set; }
        public IEnumerable<AccountDetail> CustomerAccounts { get; set; }
    }
}
