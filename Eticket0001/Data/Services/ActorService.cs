﻿using eticket.Data;
using eticket.Models;
using Microsoft.EntityFrameworkCore;

namespace Eticket0001.Data.Services
{
    public class ActorService : IActorServices
    {
        private readonly AddDbContextcs _context;
        public ActorService(AddDbContextcs context)
        {
            _context = context;
        }
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
                
            var result = await _context.actors.ToListAsync();
            return result;
        }

        public Actor GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
