using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PC_Parts_Shop_E_Commerce.Data;
using PC_Parts_Shop_E_Commerce.Data.Models;
using PC_Parts_Shop_E_Commerce.ViewModels;
namespace PC_Parts_Shop_E_Commerce.Controllers
{


    public class CPUController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CPUController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddEditCpuViewModel inputModelCpu = new AddEditCpuViewModel()
            {
                Brands = dbContext.Brands.Select(b => new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                }).ToList()
            };

            return View(inputModelCpu);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddEditCpuViewModel model)
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
                CategoryId = 1

            };

            var cpu = new CPU
            {
                Product = product,
                Name = model.Name,
                Cores = model.Cores,
                Threads = model.Threads,
                BaseClock = model.BaseClock,
                BoostClock = model.BoostClock,
                SocketType = model.SocketType
            };

            dbContext.CPUs.Add(cpu);

            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var cpu = await dbContext.CPUs
                .Include(c => c.Product)
                .FirstOrDefaultAsync(c => c.ProductId == id);

            if (cpu == null)
            {
                return NotFound();
            }

            var model = new AddEditCpuViewModel
            {
                Brands = dbContext.Brands.Select(b => new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                }).ToList(),

                ProductId = cpu.ProductId,
                ProductName = cpu.Product.ProductName,
                Price = cpu.Product.Price,
                StockQuantity = cpu.Product.StockQuantity,
                ImageURL = cpu.Product.ImageURL,
                Description = cpu.Product.Description,
                BrandId = cpu.Product.BrandId,

                Name = cpu.Name,
                Cores = cpu.Cores,
                Threads = cpu.Threads,
                BaseClock = cpu.BaseClock,
                BoostClock = cpu.BoostClock,
                SocketType = cpu.SocketType
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AddEditCpuViewModel model)
        {
            if (id != model.ProductId)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var cpu = await dbContext.CPUs
                .Include(c => c.Product)
                .FirstOrDefaultAsync(c => c.ProductId == id);

            if (cpu == null)
            {
                return NotFound();
            }

            cpu.Product.ProductName = model.ProductName;
            cpu.Product.Price = model.Price;
            cpu.Product.StockQuantity = model.StockQuantity;
            cpu.Product.ImageURL = model.ImageURL;
            cpu.Product.Description = model.Description;
            cpu.Product.BrandId = model.BrandId;

            cpu.Cores = model.Cores;
            cpu.Threads = model.Threads;
            cpu.BaseClock = model.BaseClock;
            cpu.BoostClock = model.BoostClock;
            cpu.SocketType = model.SocketType;

            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var cpu = await dbContext.CPUs
                .Include(c => c.Product)
                .FirstOrDefaultAsync(c => c.ProductId == id);
            if (cpu == null)
            {
                return NotFound();
            }
            dbContext.CPUs.Remove(cpu);
            dbContext.Products.Remove(cpu.Product!);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
