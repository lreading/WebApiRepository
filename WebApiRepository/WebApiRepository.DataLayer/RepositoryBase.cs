using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiRepository.Domain;

namespace WebApiRepository.DataLayer
{
    public class RepositoryBase<T> : IRepository<T> where T : IEntity
    {
        #region Fields, Properties and Constructors



        #endregion

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Guard(bool guardOn)
        {
            throw new NotImplementedException();
        }

        public void SetUser(string userId)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
