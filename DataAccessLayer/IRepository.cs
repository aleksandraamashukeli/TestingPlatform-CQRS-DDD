using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T> where T:  Entity
    {
        void Add(T entity);

        void Edit(T entity);

        void Delete(T entity);

        Task SaveChanges();

        IQueryable<T> GetAll();

        T getEntityById(int id);
    }
}
