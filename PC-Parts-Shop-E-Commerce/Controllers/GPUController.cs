using Microsoft.AspNetCore.Mvc;
using PC_Parts_Shop_E_Commerce.Data;
using PC_Parts_Shop_E_Commerce.Data.Models;



namespace PC_Parts_Shop_E_Commerce.Controllers
{

    
    public class GPUController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public GPUController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public IActionResult Index()
        {
            ICollection<GPU>? gpus = dbContext.GPUs.ToList();
            return View(gpus);
        }
    }


}
