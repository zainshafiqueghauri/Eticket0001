using eticket.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eticket0001.Controllers
{
    public class ActorController : Controller
    {
        private readonly AddDbContextcs _context;
        public ActorController(AddDbContextcs contextcs)
        {
            _context = contextcs;
        }
        public IActionResult Index()
        {
            var data = _context.actors.ToList();
            return View(data);
        }
        public IActionResult Ghauri()
        {
            var data = _context.actors.ToList();
            return View(data);
        }
    }
}
