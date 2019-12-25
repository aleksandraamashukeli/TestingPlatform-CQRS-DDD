using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        public DatabaseContext _dbcontext { get; set; }
        public DbSet<T> entities { get; set; }

        public Repository(DatabaseContext dbcontext)
        {
            _dbcontext = dbcontext;

            entities = dbcontext.Set<T>();
        }


        public void Add(T entity)
        {
            if (!entities.Contains(entity))
            {
                entities.Add(entity);
                 _dbcontext.SaveChanges();
            }
        }

        public void Edit(T entity)
        {
            if (!entities.Contains(entity))
            {
                entities.Update(entity);
                _dbcontext.SaveChanges();
            }
        }

        public  void Delete(T entity)
        {
            entities.Remove(entity);
            _dbcontext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }
    }
}
