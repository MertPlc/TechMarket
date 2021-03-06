using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAllAsync();  // tümünü listele
        Task<List<T>> ListAsync(ISpecification<T> specification);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> specification);
        Task<T> FirstAsync(ISpecification<T> specification);
        Task<T> FirstOrDefaultAsync(ISpecification<T> specification);
    }
}
