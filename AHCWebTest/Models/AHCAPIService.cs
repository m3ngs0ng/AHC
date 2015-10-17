using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace AHCWebTest.Models
{
    public class AHCAPIService
    {
        /// <summary>
        /// GetOrderSummaries - call api service and deserialize JSON data
        /// </summary>
        /// <param name="ordertype">type of orders to retrieve (weekly,monthly,year)</param>
        /// <returns></returns>
        public List<OrderSummary> GetOrderSummaries(AHCWebTest.Enums.OrderSummaryTypes ordertype)
        {
            string uri = "";
            if (ordertype == Enums.OrderSummaryTypes.Weekly)
               uri = "http://ahcapi.azurewebsites.net/Api/OrderSummary/WeekOverWeek";
            else if (ordertype == Enums.OrderSummaryTypes.Month)
                uri = "http://ahcapi.azurewebsites.net/Api/OrderSummary/MonthOverMonth";
            else if (ordertype == Enums.OrderSummaryTypes.Year)
                uri = "http://ahcapi.azurewebsites.net/Api/OrderSummary/YearOverYear";

            var syncClient = new WebClient();
            var content = syncClient.DownloadString(uri);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var newList = serializer.Deserialize<List<OrderSummary>>(content);
            syncClient.Dispose();
            return newList;
        }
    }
}