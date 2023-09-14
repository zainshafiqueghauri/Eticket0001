using eticket.Models;

namespace Eticket0001.Data.Services
{
    public interface IActorServices
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetbyIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);

        void Delete(int id);


    }
}
