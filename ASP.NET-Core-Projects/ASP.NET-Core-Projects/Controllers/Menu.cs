using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_Projects.Data;
using ASP.NET_Core_Projects.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Projects.Controllers
{
    public class Menu : Controller
    {
        private readonly MenuContext _context;

        public Menu(MenuContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dishes.ToListAsync());
        }

        public async Task<IActionResult> Details (int? id)
        {
            var dish = await _context.Dishes
                .Include(di=>di.DishIngredients)
                .ThenInclude(i=>i.Ingredient)
                .FirstOrDefaultAsync(x=>x.Id==id);

            if (dish == null)
            {
                return NotFound();
            }
            return View(dish);
        }
    }
}
