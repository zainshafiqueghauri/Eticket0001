using eticket.Data;
using eticket.Models;
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
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //get acto/create
        public async Task<IActionResult> Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL,Bio")] Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //GET: ACTOR/DETAIL/1
        public async Task<IActionResult> details(int id)
        {
            var actorDetail =await _service.GetbyIdAsync(id);

            if (actorDetail == null) return View("NOT FOUND");
            return View(actorDetail);   
        }
        
        
        //get actor/create
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetail = await _service.GetbyIdAsync(id);
            if (actorDetail == null) return View("NOT FOUND");
            return View(actorDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, 
            [Bind("Id, FullName, ProfilePictureURL,Bio")] Actor actor)
        {

            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));
        }


        //get actor/create
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetail = await _service.GetbyIdAsync(id);
            if (actorDetail == null) return View("NOT FOUND");
            return View(actorDetail);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetail = await _service.GetbyIdAsync(id);
            if (actorDetail == null) return View("NOT FOUND");

            _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
