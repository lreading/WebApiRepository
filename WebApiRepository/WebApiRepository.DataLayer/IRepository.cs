using System.Collections.Generic;
using WebApiRepository.Domain;

namespace WebApiRepository.DataLayer
{
    public interface IRepository<T> where T : IEntity
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        void SetUser(string userId);
        void Guard(bool guardOn);
    }
}
