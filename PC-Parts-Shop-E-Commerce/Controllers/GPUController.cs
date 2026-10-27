using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PC_Parts_Shop_E_Commerce.Data;
using PC_Parts_Shop_E_Commerce.Data.Models;
using PC_Parts_Shop_E_Commerce.ViewModels;


namespace PC_Parts_Shop_E_Commerce.Controllers
{


    public class GPUController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public GPUController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            AddEditGpuViewModel inputModelGpu = new AddEditGpuViewModel()
            {
                Brands = dbContext.Brands.Select(b => new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                }).ToList()
            };

            return View(inputModelGpu);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddEditGpuViewModel model)
        {

            if (!ModelState.IsValid)
            {
                model.Brands = await dbContext.Brands
                    .Select(b => new SelectListItem
                    {
                        Value = b.Id.ToString(),
                        Text = b.Name
                    })
                    .ToListAsync();

                return View(model);
            }

            var product = new Product
            {
                ProductName = model.ProductName,
                Price = model.Price,
                StockQuantity = model.StockQuantity,
                ImageURL = model.ImageURL,
                Description = model.Description,
                Brand = model.BrandId != 0 ? await dbContext.Brands.FindAsync(model.BrandId) : null,
                CategoryId = 2

            };

            var gpu = new GPU
            {
                Product = product,
                Chipset = model.Chipset,
                VRAM = model.VRAM,
                MemoryType = model.MemoryType,
                MemoryClock = model.MemoryClock,
                Length = model.Length,
                Cores = model.Cores

            };

            dbContext.GPUs.Add(gpu);

            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var gpu = await dbContext.GPUs
                .Include(g => g.Product)
                .FirstOrDefaultAsync(g => g.ProductId == id);

            if (gpu == null)
            {
                return NotFound();
            }

            var model = new AddEditGpuViewModel
            {
                Brands = dbContext.Brands.Select(b => new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                }).ToList(),

                ProductId = gpu.ProductId,
                ProductName = gpu.Product.ProductName,
                Price = gpu.Product.Price,
                StockQuantity = gpu.Product.StockQuantity,
                ImageURL = gpu.Product.ImageURL,
                Description = gpu.Product.Description,
                BrandId = gpu.Product.BrandId,

                Chipset = gpu.Chipset,
                VRAM = gpu.VRAM,
                MemoryType = gpu.MemoryType,
                MemoryClock = gpu.MemoryClock,
                Length = gpu.Length,
                Cores = gpu.Cores
            };

            return View(model);

        }

        public async Task<IActionResult> Edit(int id, AddEditGpuViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Brands = await dbContext.Brands
                    .Select(b => new SelectListItem
                    {
                        Value = b.Id.ToString(),
                        Text = b.Name
                    })
                    .ToListAsync();
                return View(model);
            }
            var gpu = await dbContext.GPUs
                .Include(g => g.Product)
                .FirstOrDefaultAsync(g => g.ProductId == model.ProductId);
            if (gpu == null)
            {
                return NotFound();
            }
            gpu.Product.ProductName = model.ProductName;
            gpu.Product.Price = model.Price;
            gpu.Product.StockQuantity = model.StockQuantity;
            gpu.Product.ImageURL = model.ImageURL;
            gpu.Product.Description = model.Description;
            gpu.Product.BrandId = model.BrandId;

            gpu.Chipset = model.Chipset;
            gpu.VRAM = model.VRAM;
            gpu.MemoryType = model.MemoryType;
            gpu.MemoryClock = model.MemoryClock;
            gpu.Length = model.Length;
            gpu.Cores = model.Cores;
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var gpu = await dbContext.GPUs
                .Include(g => g.Product)
                .FirstOrDefaultAsync(g => g.ProductId == id);
            if (gpu == null)
            {
                return NotFound();
            }
            dbContext.GPUs.Remove(gpu);
            dbContext.Products.Remove(gpu.Product!);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
