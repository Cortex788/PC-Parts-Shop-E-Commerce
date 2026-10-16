using Microsoft.AspNetCore.Mvc;
using PC_Parts_Shop_E_Commerce.Data;
using PC_Parts_Shop_E_Commerce.Models;
using System.Diagnostics;

namespace PC_Parts_Shop_E_Commerce.Controllers
{
    using PC_Parts_Shop_E_Commerce.ModelsViews;
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var products = _dbContext.Products
                .Select(product => new ProductCardViewModel
                {
                    Id = product.Id,
                    Name = product.ProductName,
                    Brand = product.Brand.Name,
                    Price = product.Price,
                    ImageURL = product.ImageURL
                })
                .Take(8)
                .ToList();

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
