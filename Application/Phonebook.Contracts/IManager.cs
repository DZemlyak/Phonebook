using System;
using System.Linq;
using System.Linq.Expressions;

namespace Phonebook.Contracts
{
    public interface IManager<T> where T : class, IDbEntity {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
        T GetByPrimaryKey(params object[] keys);
    }
}
