using Microsoft.AspNetCore.Mvc;
using QueryString.Models;

namespace QueryString.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProdact()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            var product = new Product();
            product.Name = "SAADHB";
            product.Quantity = 52;
            return View(product);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }
    }
}
