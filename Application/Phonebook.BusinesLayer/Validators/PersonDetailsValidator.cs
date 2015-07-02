using System;
using Phonebook.Contracts;
using Phonebook.Model;

namespace Phonebook.BusinesLayer.Validators
{
    public sealed class PersonDetailsValidator : IValidator<PersonDetails>
    {
        private readonly IRepository<PersonDetails> _repository;
        private readonly IValidator<Person> _validator;

        public PersonDetailsValidator(IRepository<PersonDetails> repository, IValidator<Person> validator) {
            _repository = repository;
            _validator = validator;
        }

        public bool IsValid(PersonDetails entity) {
            return _validator.IsExists(entity.PersonId) &&
                   !String.IsNullOrEmpty(entity.Address) &&
                   !(entity.Address.Length > 50) &&
                   !(entity.Description.Length > 255);
        }

        public bool IsExists(PersonDetails entity) {
            return IsExists(entity.PersonId);
        }

        public bool IsExists(params object[] keys) {
            return _repository.GetByPrimaryKey(keys) != null;
        }
    }
}
