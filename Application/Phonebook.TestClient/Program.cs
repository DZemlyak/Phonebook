using System;
using System.Linq;
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
                Console.WriteLine(db.Persons.Count());
            }
        }
    }
}
