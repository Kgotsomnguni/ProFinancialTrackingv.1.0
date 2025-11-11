using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFinancialTrackingv._1._0.Models
{
    public class Expense
    {
        public string Category {  get; set; }
        public decimal Amount { get; set; }
        public DateTime DateSpent {  get; set; }
        public string Note {  get; set; }
    }
}
