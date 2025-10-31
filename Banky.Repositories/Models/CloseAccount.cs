using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky.Repositories.Models
{
    public class CloseAccount
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
    }
}
