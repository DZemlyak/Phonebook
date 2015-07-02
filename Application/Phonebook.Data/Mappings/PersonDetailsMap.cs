using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Phonebook.Model;

namespace Phonebook.Data.Mappings
{
    public class PersonDetailsMap : EntityTypeConfiguration<PersonDetails> {
        public PersonDetailsMap() {
            HasKey(s => s.PersonId);
            Property(s => s.Address).IsRequired();
            Property(s => s.Description).IsRequired();
            ToTable("PersonDetails");

            HasRequired(s => s.Person).WithOptional(s => s.PersonDetails).WillCascadeOnDelete(false);
        }
    }
}
