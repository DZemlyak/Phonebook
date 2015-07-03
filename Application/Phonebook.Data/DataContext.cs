using System.Collections.Generic;
using System.Data.Entity;
using Phonebook.Data.Mappings;
using Phonebook.Model;

namespace Phonebook.Data
{
    public sealed class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PersonDetails> PersonDetailses { get; set; }

        public DataContext() : base("PhonebookConnectionString") {
            Database.SetInitializer(new PhonebookInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonDetailsMap());
            modelBuilder.Configurations.Add(new PhoneMap());
        }

        private class PhonebookInitializer : CreateDatabaseIfNotExists<DataContext>
        {
            protected override void Seed(DataContext context)
            {
                var persomList = new List<Person> {
                    new Person { FirstName = "Dmitriy", LastName = "Zemlyak" },
                    new Person { FirstName = "Sergey", LastName = "Serkov" },
                    new Person { FirstName = "Darya", LastName = "Spivak" },
                    new Person { FirstName = "Alexander", LastName = "Kirichenko" }
                };
                context.Persons.AddRange(persomList);
                context.SaveChanges();
                
                var detailsList = new List<PersonDetails> {
                    new PersonDetails { Address = "Kharkiv, Lenina street, 4/3", Description = "Poor student.", PersonId = 1},
                    new PersonDetails { Address = "Kharkiv, Chkalova street, 6/45", Description = "Poor student.", PersonId = 2},
                    new PersonDetails { Address = "Kharkiv, Lenina street, 12/9", Description = "Poor student.", PersonId = 3},
                    new PersonDetails { Address = "Kharkiv, Chkalova street, 23/2", Description = "Poor student.", PersonId = 4}
                };
                context.PersonDetailses.AddRange(detailsList);
                context.SaveChanges();
                
                var phoneList = new List<Phone> {
                    new Phone { Number = "+38 095 999 99 99", PhoneType = PhoneType.Mobile, PersonId = 1},
                    new Phone { Number = "+380 057 692 438", PhoneType = PhoneType.Stationary, PersonId = 1},
                    new Phone { Number = "+38 099 222 33 44", PhoneType = PhoneType.Mobile, PersonId = 2},
                    new Phone { Number = "+380 057 798 123", PhoneType = PhoneType.Fax, PersonId = 3},
                    new Phone { Number = "+380 057 798 124", PhoneType = PhoneType.Stationary, PersonId = 3},
                    new Phone { Number = "+38 095 111 45 46", PhoneType = PhoneType.Mobile, PersonId = 4}
                };
                context.Phones.AddRange(phoneList);
                context.SaveChanges();
                
                base.Seed(context);
            }
        }
    }
}
