using Microsoft.AspNetCore.Mvc;
using PC_Parts_Shop_E_Commerce.Data;
using PC_Parts_Shop_E_Commerce.Data.Models;
using PC_Parts_Shop_E_Commerce.ModelsViews;

namespace PC_Parts_Shop_E_Commerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ProductController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult GPU()
        {
            var gpus = dbContext.GPUs
        .Select(gpu => new GpuCardViewModel
        {
            Id = gpu.ProductId,
            Name = gpu.Product.ProductName,
            Brand = gpu.Product.Brand.Name,
            Price = gpu.Product.Price,
            StockQuantity = gpu.Product.StockQuantity,
            ImageURL = gpu.Product.ImageURL,
            Chipset = gpu.Chipset,
            VRAM = gpu.VRAM,
            MemoryType = gpu.MemoryType,
            MemoryClock = gpu.MemoryClock
        })
        .ToList();

            return View(gpus);
        }

        public IActionResult CPU()
        {
            var cpus = dbContext.CPUs
                .Select(cpu => new CpuCardViewModel
                {
                    Id = cpu.ProductId,
                    Name = cpu.Product.ProductName,
                    Brand = cpu.Product.Brand.Name,
                    Price = cpu.Product.Price,
                    StockQuantity = cpu.Product.StockQuantity,
                    ImageURL = cpu.Product.ImageURL,
                    Cores = cpu.Cores,
                    Threads = cpu.Threads,
                    BaseClock = cpu.BaseClock,
                    BoostClock = cpu.BoostClock,
                    SocketType = cpu.SocketType,
                    IntegratedGraphics = cpu.IntegratedGraphics
                })
                .ToList();

            return View(cpus);
        }
    }
}
