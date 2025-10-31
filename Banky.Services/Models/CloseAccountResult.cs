using Banky.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky.Services.Models
{
    public class CloseAccountResult : ICloseAccountResult
    {
        public bool Succeeded { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
    }
}
