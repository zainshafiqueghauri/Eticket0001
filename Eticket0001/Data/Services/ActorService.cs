using eticket.Data;
using eticket.Models;
using Eticket0001.Data.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Eticket0001.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorServices
    {
        public ActorService(AddDbContextcs context) : base(context)
        {

        }
    }
}
