using System.Collections.Generic;

namespace Phonebook.Model
{
    public class Person : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual List<Phone> Phones { get; set; }
        public virtual PersonDetails PersonDetails { get; set; }

        public Person() {
            Phones = new List<Phone>();
        }
    }
}
