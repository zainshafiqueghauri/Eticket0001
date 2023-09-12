using eticket.Data;
using Eticket0001.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace Eticket0001.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorServices _service;
        public ActorController(IActorServices service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        //get acto/create
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
