using eticket.Models;

namespace Eticket0001.Data.Services
{
    public interface IActorServices
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetbyId(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);

        void Delete(int id);


    }
}
