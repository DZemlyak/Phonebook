using System;
using System.Collections.Generic;
using System.Text;

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

        public override string ToString() {
            var builder = new StringBuilder();
            builder.Append(string.Format("Full Name: {0}\n{1}\n", LastName + " " + FirstName, PersonDetails));
            foreach (var phone in Phones) {
                builder.Append(Environment.NewLine + phone + Environment.NewLine);
            }
            return builder.ToString();
        }
    }
}
