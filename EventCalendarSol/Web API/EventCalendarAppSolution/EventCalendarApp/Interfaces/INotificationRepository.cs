using System.Linq.Expressions;

namespace EventCalendarApp.Interfaces
{
    public interface INotificationRepository<K, T>
    {
        T GetById(K key);
        IList<T> GetAll(Func<T, bool> value);
        T Add(T entity);
        T Update(T entity);
        T Delete(K key);
    }
}