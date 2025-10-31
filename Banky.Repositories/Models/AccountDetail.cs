using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky.Repositories.Models
{
    public class AccountDetail
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public short AccountTypeId { get; set; }
        public short AccountStatusId { get; set; }
        public double Balance { get; set; }
    }
}
