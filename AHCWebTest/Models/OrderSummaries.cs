using AHCWebTest.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AHCWebTest.Models
{
    public class OrderSummaries
    {
        private OrderSummaryTypes ordersummarytype;

        public List<OrderSummary> OrderSummaryList { get; set; }
        public OrderSummaryTypes OrderSummaryType { get { return ordersummarytype; } }
        /// <summary>
        /// OrderSummaries - constructor
        /// </summary>
        public OrderSummaries()
        {
            ordersummarytype = OrderSummaryTypes.Weekly;
        }
        /// <summary>
        /// OrderSummaries - constructor to set ordersummarytype
        /// </summary>
        /// <param name="ordertype">enum OrderSummaryTypes</param>
        public OrderSummaries(OrderSummaryTypes ordertype)
        {
           ordersummarytype = ordertype;
        }
        /// <summary>
        /// SumTotalOrderAmounts - get sum of all order amounts
        /// </summary>
        /// <returns></returns>
        public decimal SumTotalOrderAmounts()
        {
            decimal total = OrderSummaryList.Sum(item => item.TotalOrderedAmount);
            return total;
        }
        /// <summary>
        /// SumTotalShippedAmounts - get sum of all shipped amounts
        /// </summary>
        /// <returns></returns>
        public decimal SumTotalShippedAmounts()
        {
            decimal total = OrderSummaryList.Sum(item => item.TotalShippedAmount);
            return total;
        }
        /// <summary>
        /// GetAverageOrderAmount - get average of all order amounts
        /// </summary>
        /// <returns></returns>
        public decimal GetAverageOrderAmount()
        {
            decimal total = OrderSummaryList.Average(item => item.TotalOrderedAmount);
            return total;
        }
        /// <summary>
        /// GetAverageShippedAmounts - get average of all shipped amounts
        /// </summary>
        /// <returns></returns>
        public decimal GetAverageShippedAmounts()
        {
            decimal total = OrderSummaryList.Average(item => item.TotalShippedAmount);
            return total;
        }
    }
}