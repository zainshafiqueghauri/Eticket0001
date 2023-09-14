using eticket.Data;
using eticket.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Eticket0001.Data.Services
{
    public class ActorService : IActorServices
    {
        private readonly AddDbContextcs _context;
        public ActorService(AddDbContextcs context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
            await _context.actors.AddAsync(actor);
            await _context.SaveChangesAsync(); 
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
                
            var result = await _context.actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetbyIdAsync(int id)
        {
            var result = await _context.actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
