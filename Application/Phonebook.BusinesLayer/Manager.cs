using System;
using System.Linq;
using System.Linq.Expressions;
using Phonebook.Contracts;

namespace Phonebook.BusinesLayer
{
    public class Manager<T> : IManager<T> where T : class, IDbEntity
    {
        private readonly IRepository<T> _repository;
        private readonly IValidator<T> _validator; 

        public Manager(IRepository<T> repository, IValidator<T> validator) {
            _repository = repository;
            _validator = validator;
        }

        public void Add(T entity) {
            if (!_validator.IsValid(entity))
                throw new ArgumentException("Entity is not valid.");
            if (_validator.IsExists(entity))
                throw new ArgumentException("Entity is already exists.");
            _repository.Add(entity);
            _repository.SaveChanges();
        }

        public void Update(T entity) {
            if (!_validator.IsExists(entity))
                throw new ArgumentException("Entity does not exist.");
            _repository.SaveChanges();
        }

        public void Remove(T entity) {
            if (!_validator.IsExists(entity))
                throw new ArgumentException("Entity does not exist.");
            _repository.Remove(entity);
            _repository.SaveChanges();
        }

        public IQueryable<T> GetAll() {
            return _repository.GetAll();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression) {
            return _repository.GetWhere(expression);
        }

        public T GetByPrimaryKey(params object[] keys) {
            if (!_validator.IsExists(keys))
                throw new ArgumentException("Entity does not exist.");
            return _repository.GetByPrimaryKey(keys);
        }
    }
}
