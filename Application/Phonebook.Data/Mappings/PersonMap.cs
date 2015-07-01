using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Phonebook.Model;

namespace Phonebook.Data.Mappings
{
    public class PersonMap : EntityTypeConfiguration<Person> {
        public PersonMap() {
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.FirstName).IsRequired();
            Property(s => s.LastName).IsRequired();
            ToTable("Person");

            HasRequired(s => s.PersonDetails).WithRequiredPrincipal(s => s.Person).WillCascadeOnDelete(false);
            //HasMany(s => s.Phones).WithRequired(s => s.Person).HasForeignKey(s => s.PersonId).WillCascadeOnDelete(true);
        }
    }
}
