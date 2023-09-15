using eticket.Data;
using eticket.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Eticket0001.Data.Base
{
    public class EntityBaseRepository<T> : iEntityBaseRepository<T> where T : class, iEntityBase, new()
    {
        private readonly AddDbContextcs _context;
        public EntityBaseRepository(AddDbContextcs context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity) => await _context.Set<T>().AddAsync(entity);
        

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
        
        public async Task<T> GetbyIdAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
        }
    }
}
