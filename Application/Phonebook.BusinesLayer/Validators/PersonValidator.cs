using System;
using Phonebook.Contracts;
using Phonebook.Model;

namespace Phonebook.BusinesLayer.Validators
{
    public sealed class PersonValidator : IValidator<Person> {
        private readonly IRepository<Person> _repository;

        public PersonValidator(IRepository<Person> repository) {
            _repository = repository;
        }

        public bool IsValid(Person entity) {
            var validity = !String.IsNullOrEmpty(entity.LastName) && 
                           !String.IsNullOrEmpty(entity.FirstName) &&
                           !(entity.FirstName.Length > 20) &&
                           !(entity.LastName.Length > 20);

            return validity;
        }

        public bool IsExists(Person entity) {
            return IsExists(entity.Id);
        }

        public bool IsExists(params object[] keys) {
            return _repository.GetByPrimaryKey(keys) != null;
        }
    }
}
