using eticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eticket0001.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AddDbContextcs _context;
        public ProducerController(AddDbContextcs contextcs)
        {
            _context = contextcs;
        }
        public async Task<IActionResult> Index()
        {
            var allproducer = await _context.producer.ToListAsync();
            return View();
        }
    }
}
