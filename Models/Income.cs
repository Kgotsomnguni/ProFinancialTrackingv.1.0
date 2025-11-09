using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFinancialTrackingv._1._0.Models
{
    public class Income
    {
        public string Source { get; set; }  // where the money comes from
        public decimal Amount { get; set; } // how much
        public DateTime DateRecieved { get; set; } // when it was recieved
    }
}
