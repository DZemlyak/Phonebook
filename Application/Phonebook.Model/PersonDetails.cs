using Phonebook.Contracts;

namespace Phonebook.Model
{
    public class PersonDetails : IDbEntity
    {
        public long PersonId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public virtual Person Person { get; set; }

        public override string ToString() {
            return string.Format("Address: {0}\nDescription: {1}", Address, Description);
        }
    }
}
