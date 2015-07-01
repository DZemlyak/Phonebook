using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Phonebook.Model;

namespace Phonebook.Data.Mappings
{
    public class PhoneMap : EntityTypeConfiguration<Phone> {
        public PhoneMap() {
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.PersonId).IsRequired();
            Property(s => s.Number).IsRequired();
            Property(s => s.PhoneType).IsRequired();
            ToTable("Phone");
        }
    }
}
