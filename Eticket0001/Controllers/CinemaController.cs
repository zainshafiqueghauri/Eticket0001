using eticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eticket0001.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AddDbContextcs _context;
        public CinemaController(AddDbContextcs contextcs)
        {
            _context = contextcs;
        }
        public async Task<IActionResult> Index()
        {
            var allcinema = await _context.Cinema.ToListAsync();
            return View();
        }
    }
}
