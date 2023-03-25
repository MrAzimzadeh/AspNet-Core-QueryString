using Microsoft.AspNetCore.Mvc;
using QueryString.Models;
using System.Diagnostics;

namespace QueryString.Controllers
{
    public class QueryData
    {
        public  int a { get; set; }
        public string b { get; set; }
        public string c { get; set; }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(QueryData queryData)
        {
            //! QueryString
            //var queryString = Request.QueryString;
            var ayeryString = Request.QueryString; // Request yapllan endpoint •e query string parametresi eklenmis mi eklenmemis mi bununlailgili bilgi verir.
            //var a = Request.Query["a"].ToString(); // urlde olani goturub bize getirir 
            //var b = Request.Query["b"].ToString();
            return View();
        }

        //public IActionResult Verial(string a)

        public IActionResult Verial()
        {
            return View();
        }


        /// <summary>
        /// Header 
        /// </summary>
        /// <returns></returns>
        public IActionResult VeriAlHeader()
        {
            var headers = Request.Headers.ToList();
            return View();
        }

        public IActionResult Privacy(QueryData data)
        {
            var req = Request.RouteValues;
            var routeDat = Request.RouteValues;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}