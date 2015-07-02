using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Phonebook.Model;

namespace Phonebook.Data.Mappings
{
    internal sealed class PersonMap : EntityTypeConfiguration<Person> {
        public PersonMap() {
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.FirstName).IsRequired().HasMaxLength(20);
            Property(s => s.LastName).IsRequired().HasMaxLength(20);
            ToTable("Person");
        }
    }
}
