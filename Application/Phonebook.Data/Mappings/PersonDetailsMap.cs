using System.Data.Entity.ModelConfiguration;
using Phonebook.Model;

namespace Phonebook.Data.Mappings
{
    internal sealed class PersonDetailsMap : EntityTypeConfiguration<PersonDetails> {
        public PersonDetailsMap() {
            HasKey(s => s.PersonId);
            Property(s => s.Address).IsRequired().HasMaxLength(50);
            Property(s => s.Description).IsOptional().HasMaxLength(255);
            ToTable("PersonDetails");

            HasRequired(s => s.Person).WithOptional(s => s.PersonDetails).WillCascadeOnDelete(true);
        }
    }
}
