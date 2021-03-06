using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using itec_backend.Entities;

namespace itec_backend.Data
{
    public interface IRepository<T> where T: Entity
    {    
        Task<T> GetAsync<TKey>(TKey id);
        Task<IQueryable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteAsync(int id);
        IQueryable<T> Queryable { get; }
    }
}