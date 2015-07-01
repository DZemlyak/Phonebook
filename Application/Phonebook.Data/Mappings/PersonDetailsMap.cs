using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Phonebook.Model;

namespace Phonebook.Data.Mappings
{
    public class PersonDetailsMap : EntityTypeConfiguration<PersonDetails> {
        public PersonDetailsMap() {
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.PersonId).IsRequired();
            Property(s => s.Address).IsRequired();
            Property(s => s.Description).IsRequired();
            ToTable("PersonDetails");
        }
    }
}
