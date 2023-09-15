using eticket.Models;

namespace Eticket0001.Data.Base
{
    public interface iEntityBaseRepository<T> where T : class,iEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetbyIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
    }
}
