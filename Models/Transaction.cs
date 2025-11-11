using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFinancialTrackingv._1._0.Models
{
    public class Transaction
    {
        public string Type { get; set;}
        public decimal Amount {  get; set;}
        public DateTime Date { get; set;}
        public string Description {  get; set;}

    }
}
