namespace Phonebook.Model
{
    public class BaseEntity : IDbEntity
    {
        public long Id { get; private set; }
    }
}
