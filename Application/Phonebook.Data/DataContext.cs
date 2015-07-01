using System.Data.Entity;
using Phonebook.Data.Mappings;
using Phonebook.Model;

namespace Phonebook.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PersonDetails> PersonDetailses { get; set; }

        public DataContext() : base("PhonebookConnectionString") {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonDetailsMap());
            modelBuilder.Configurations.Add(new PhoneMap());
        }
    }
}
