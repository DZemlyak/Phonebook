namespace Phonebook.Model
{
    public class PersonDetails : BaseEntity
    {
        public long PersonId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public virtual Person Person { get; set; }
    }
}
