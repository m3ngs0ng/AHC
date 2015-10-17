using AHCWebTest.Models;
using AHCWebTest.Enums;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AHCWebTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrderSummary(OrderSummaryTypes ordertype)
        {
            var apiService = new AHCAPIService();
            var orderSummaries = new OrderSummaries(ordertype);

            orderSummaries.OrderSummaryList = apiService.GetOrderSummaries(ordertype);

            if (ordertype == OrderSummaryTypes.Weekly)
                ViewBag.Title = "Weekly Orders";
            else if (ordertype == OrderSummaryTypes.Month)
                ViewBag.Title = "Monthly Orders";
            else
                ViewBag.Title = "Yearly Orders";

            return View(orderSummaries);
        }
    }
}