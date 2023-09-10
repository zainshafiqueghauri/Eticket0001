 using eticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eticket0001.Controllers
{
    public class MovieController : Controller
    {
        private readonly AddDbContextcs _Context;
        public MovieController(AddDbContextcs contextcs)
        {
            _Context = contextcs;
        }
        public async Task <IActionResult> Index()
        {
            var allmovie = await _Context.movie.Include(n => n.cinema).ToListAsync();
            return View(allmovie);
        }
    }
}
