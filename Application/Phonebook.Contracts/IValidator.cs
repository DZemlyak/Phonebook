namespace Phonebook.Contracts
{
    public interface IValidator<in T> where T : class, IDbEntity{
        bool IsValid(T entity);
        bool IsExists(T entity);
        bool IsExists(params object[] keys);
    }
}
