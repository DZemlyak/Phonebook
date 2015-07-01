using System;
using Phonebook.Data;
using Phonebook.Model;

namespace Phonebook.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataContext())
            {
                db.Persons.Add(new Person { FirstName = "Dmitriy", LastName = "Zemlyak"});
                db.SaveChanges();

                foreach (var person in db.Persons)
                {
                    Console.WriteLine(person.FirstName);
                }
            }
        }
    }
}
