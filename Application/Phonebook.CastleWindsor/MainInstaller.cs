using System.Data.Entity;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Phonebook.BusinesLayer;
using Phonebook.BusinesLayer.Validators;
using Phonebook.Contracts;
using Phonebook.Data;
using Phonebook.Model;

namespace Phonebook.CastleWindsor
{
    public class MainInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(Component.For<DataContext>().LifestyleSingleton());
            container.Register(Component.For(typeof (IDbSet<>))
                .ImplementedBy(typeof(DbSet<>)));
            container.Register(Component.For(typeof(IRepository<>))
                .ImplementedBy(typeof(Repository<>)));
            container.Register(Component.For(typeof(IManager<>))
                .ImplementedBy(typeof(Manager<>)));
            container.Register(Component.For(typeof(IManagerAsync<>))
                .ImplementedBy(typeof(ManagerAsync<>)));
            container.Register(Component.For(typeof(IValidator<Person>))
                    .ImplementedBy(typeof(PersonValidator))
                    .LifestylePerThread());
            container.Register(Component.For(typeof(IValidator<PersonDetails>))
                    .ImplementedBy(typeof(PersonDetailsValidator))
                    .LifestylePerThread());
            container.Register(Component.For(typeof(IValidator<Phone>))
                    .ImplementedBy(typeof(PhoneValidator))
                    .LifestylePerThread());
        }
    }
}
