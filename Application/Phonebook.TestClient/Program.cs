using System;
using Castle.Windsor;
using Phonebook.CastleWindsor;
using Phonebook.Contracts;
using Phonebook.Model;

namespace Phonebook.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer().Install(new MainInstaller());

            var dc = container.Resolve<IManager<Person>>();
            foreach (var person in dc.GetAll())
            {
                Console.WriteLine(person);
            }
        }
    }
}
