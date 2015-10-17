using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AHCWebTest.Models
{
    public class OrderSummary
    {
        public int Id { get; set; }
        public DateTime PeriodDate { get; set; }
        public string PeriodLabel { get; set; }
        public int Ordered { get; set; }
        public int Shipped { get; set; }
        public int Remainder { get; set; }
        public decimal TotalOrderedAmount { get; set; }
        public decimal TotalShippedAmount { get; set; }

    }
}