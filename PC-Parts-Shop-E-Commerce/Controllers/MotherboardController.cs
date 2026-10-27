using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PC_Parts_Shop_E_Commerce.Data;
using PC_Parts_Shop_E_Commerce.Data.Models;
using PC_Parts_Shop_E_Commerce.ViewModels;

namespace PC_Parts_Shop_E_Commerce.Controllers
{
    public class MotherboardController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public MotherboardController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddEditMotherboardViewModel inputModelMotherboard = new AddEditMotherboardViewModel()
            {
                Brands = dbContext.Brands.Select(b => new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                }).ToList()
            };

            return View(inputModelMotherboard);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Add(AddEditMotherboardViewModel model)
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
                BrandId = model.BrandId,
                CategoryId = 4,
            };
            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();
            var motherboard = new Motherboard
            {
                Product = product,
                Name = model.ProductName,
                Socket = model.Socket,
                FormFactor = model.FormFactor,
                Chipset = model.Chipset,
                MemorySlots = model.MemorySlots,
            };
            dbContext.Motherboards.Add(motherboard);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var motherboard = await dbContext.Motherboards
                .Include(mb => mb.Product)
                .FirstOrDefaultAsync(mb => mb.ProductId == id);

            if (motherboard == null)
            {
                return NotFound();
            }

            AddEditMotherboardViewModel model = new AddEditMotherboardViewModel
            {
                ProductName = motherboard.Product.ProductName,
                Price = motherboard.Product.Price,
                StockQuantity = motherboard.Product.StockQuantity,
                ImageURL = motherboard.Product.ImageURL,
                Description = motherboard.Product.Description,
                BrandId = motherboard.Product.BrandId,
                Socket = motherboard.Socket,
                FormFactor = motherboard.FormFactor,
                Chipset = motherboard.Chipset,
                MemorySlots = motherboard.MemorySlots,
                Brands = await dbContext.Brands
                    .Select(b => new SelectListItem
                    {
                        Value = b.Id.ToString(),
                        Text = b.Name
                    })
                    .ToListAsync()
            };
            return View(model);

        }

        public async Task<IActionResult> Edit(int id, AddEditMotherboardViewModel model)
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
            var motherboard = await dbContext.Motherboards
                .Include(mb => mb.Product)
                .FirstOrDefaultAsync(mb => mb.ProductId == id);

            if (motherboard == null)
            {
                return NotFound();
            }

            motherboard.Product.ProductName = model.ProductName;
            motherboard.Product.Price = model.Price;
            motherboard.Product.StockQuantity = model.StockQuantity;
            motherboard.Product.ImageURL = model.ImageURL;
            motherboard.Product.Description = model.Description;
            motherboard.Product.BrandId = model.BrandId;
            motherboard.Socket = model.Socket;
            motherboard.FormFactor = model.FormFactor;
            motherboard.Chipset = model.Chipset;
            motherboard.MemorySlots = model.MemorySlots;
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var motherboard = await dbContext.Motherboards
                .Include(mb => mb.Product)
                .FirstOrDefaultAsync(mb => mb.ProductId == id);
            if (motherboard == null)
            {
                return NotFound();
            }
            dbContext.Products.Remove(motherboard.Product);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
