using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Phonebook.Contracts;

namespace Phonebook.Data
{
    public sealed class Repository<T> : IRepository<T> where T : class, IDbEntity
    {
        private readonly DataContext _context;
        private readonly IDbSet<T> _entities; 

        public Repository(DataContext context) {
            _context = context;
            _entities = context.Set<T>();
        }

        public void Add(T entity) {
            _entities.Add(entity);
        }

        public void Remove(T entity) {
            _entities.Remove(entity);
        }

        public IQueryable<T> GetAll() {
            return _entities;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression) {
            return _entities.Where(expression);
        }

        public T GetByPrimaryKey(params object[] keys) {
            return _entities.Find(keys);
        }

        public void SaveChanges() {
            _context.SaveChanges();
        }
    }
}
