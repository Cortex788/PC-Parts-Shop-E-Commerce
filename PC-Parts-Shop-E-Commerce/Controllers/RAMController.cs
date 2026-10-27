using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PC_Parts_Shop_E_Commerce.Data;
using PC_Parts_Shop_E_Commerce.Data.Models;
using PC_Parts_Shop_E_Commerce.ViewModels;

namespace PC_Parts_Shop_E_Commerce.Controllers
{
    public class RAMController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public RAMController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Add()
        {
            AddEditRamViewModel inputModelRam = new AddEditRamViewModel()
            {
                Brands = dbContext.Brands.Select(b => new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                }).ToList()
            };

            return View(inputModelRam);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddEditRamViewModel model)
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
                Description = model.Description,
                ImageURL = model.ImageURL,
                BrandId = model.BrandId,
                CategoryId = 3,
            };

            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();

            var ram = new Data.Models.RAM
            {
                Product = product,
                Capacity = model.Capacity,
                MemoryType = model.MemoryType,
                MemorySpeed = model.MemorySpeed
            };
            dbContext.RAMs.Add(ram);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public Task<IActionResult> Edit(int id)
        {
            var ram = dbContext.RAMs.Include(r => r.Product).FirstOrDefault(r => r.ProductId == id);
            if (ram == null)
            {
                return Task.FromResult<IActionResult>(NotFound());
            }
            var model = new AddEditRamViewModel
            {
                ProductName = ram.Product.ProductName,
                Price = ram.Product.Price,
                StockQuantity = ram.Product.StockQuantity,
                Description = ram.Product.Description,
                ImageURL = ram.Product.ImageURL,
                BrandId = ram.Product.BrandId,
                Capacity = ram.Capacity,
                MemoryType = ram.MemoryType,
                MemorySpeed = ram.MemorySpeed,
                Brands = dbContext.Brands.Select(b => new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                }).ToList()
            };
            return Task.FromResult<IActionResult>(View(model));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AddEditRamViewModel model)
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
            var ram = await dbContext.RAMs.Include(r => r.Product).FirstOrDefaultAsync(r => r.ProductId == id);
            if (ram == null)
            {
                return NotFound();
            }
            ram.Product.ProductName = model.ProductName;
            ram.Product.Price = model.Price;
            ram.Product.StockQuantity = model.StockQuantity;
            ram.Product.Description = model.Description;
            ram.Product.ImageURL = model.ImageURL;
            ram.Product.BrandId = model.BrandId;
            ram.Capacity = model.Capacity;
            ram.MemoryType = model.MemoryType;
            ram.MemorySpeed = model.MemorySpeed;
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var ram = await dbContext.RAMs.Include(r => r.Product).FirstOrDefaultAsync(r => r.ProductId == id);
            if (ram == null)
            {
                return NotFound();
            }
            dbContext.Products.Remove(ram.Product);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
