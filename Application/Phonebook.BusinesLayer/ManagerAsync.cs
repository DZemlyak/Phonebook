using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Phonebook.Contracts;

namespace Phonebook.BusinesLayer
{
    public class ManagerAsync<T> : IManagerAsync<T> where T : class, IDbEntity {
        private readonly IRepository<T> _repository;
        private readonly IValidator<T> _validator;

        public ManagerAsync(IRepository<T> repository, IValidator<T> validator) {
            _repository = repository;
            _validator = validator;
        }

        public async Task AddAsync(T entity) {
            await Task.Run(() => {
                if (!_validator.IsValid(entity))
                    throw new ArgumentException("Entity is not valid.");
                _repository.Add(entity);
                _repository.SaveChanges();
            });
        }

        public async Task UpdateAsync(T entity) {
            await Task.Run(() => {
                if (!_validator.IsValid(entity))
                    throw new ArgumentException("Entity is not valid.");
                if (!_validator.IsExists(entity))
                    throw new ArgumentException("Entity does not exist.");
                _repository.SaveChanges();
            });
        }

        public async Task RemoveAsync(T entity) {
            await Task.Run(() => {
                if (!_validator.IsExists(entity))
                    throw new ArgumentException("Entity does not exist.");
                _repository.Remove(entity);
                _repository.SaveChanges();
            });
        }

        public async Task<IQueryable<T>> GetAllAsync() {
            var result = await Task.Run(() => _repository.GetAll());
            return result;
        }

        public async Task<IQueryable<T>> GetWhereAsync(Expression<Func<T, bool>> expression) {
            var result = await Task.Run(() => _repository.GetWhere(expression));
            return result;
        }

        public async Task<T> GetByPrimaryKeyAsync(params object[] keys) {
            var result = await Task.Run(() => {
                if (!_validator.IsExists(keys))
                    throw new ArgumentException("Entity does not exist.");
                return _repository.GetByPrimaryKey(keys);
            });
            return result;
        }
    }
}
