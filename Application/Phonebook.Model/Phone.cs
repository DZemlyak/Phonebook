namespace Phonebook.Model
{
    public class Phone : BaseEntity
    {
        public long PersonId { get; set; }
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; }

        public virtual Person Person { get; set; }
    }
}
