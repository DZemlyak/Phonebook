namespace Phonebook.Model
{
    public class Phone : BaseEntity
    {
        public long PersonId { get; set; }
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; }

        public virtual Person Person { get; set; }

        public override string ToString() {
            return string.Format("Phone Type: {0}\nPhone Number: {1}", PhoneType, Number);
        }
    }
}
