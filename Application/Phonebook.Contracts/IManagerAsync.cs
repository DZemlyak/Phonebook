using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Phonebook.Contracts
{
    public interface IManagerAsync<T> where T : class, IDbEntity {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> GetWhereAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByPrimaryKeyAsync(params object[] keys);
    }
}
