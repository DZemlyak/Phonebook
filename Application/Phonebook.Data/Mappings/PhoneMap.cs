using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Phonebook.Model;

namespace Phonebook.Data.Mappings
{
    internal sealed class PhoneMap : EntityTypeConfiguration<Phone> {
        public PhoneMap() {
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.PersonId).IsRequired();
            Property(s => s.Number).IsRequired().HasMaxLength(18);
            Property(s => s.PhoneType).IsRequired();
            ToTable("Phone");
        }
    }
}
