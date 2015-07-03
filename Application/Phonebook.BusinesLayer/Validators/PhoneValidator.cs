using System;
using System.Text.RegularExpressions;
using Phonebook.Contracts;
using Phonebook.Model;

namespace Phonebook.BusinesLayer.Validators
{
    public sealed class PhoneValidator : IValidator<Phone> {
        private readonly IRepository<Phone> _repository;
        private readonly IValidator<Person> _validator;

        public PhoneValidator(IRepository<Phone> repository, IValidator<Person> validator) {
            _repository = repository;
            _validator = validator;
        }

        public bool IsValid(Phone entity) {
            return _validator.IsExists(entity.PersonId) &&
                   Regex.IsMatch(entity.Number, @"\+{0,1}\d{1,3}[ -]\d{1,3}[ -]\d{3}[ -]\d{2}[ -]\d{2}");
        }

        public bool IsExists(Phone entity) {
            return IsExists(entity.PersonId);
        }

        public bool IsExists(params object[] keys) {
            return _repository.GetByPrimaryKey(keys) != null;
        }
    }
}
