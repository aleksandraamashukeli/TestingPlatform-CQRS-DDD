using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

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
            }
        }

        public void Edit(T entity)
        {
            if (!entities.Contains(entity))
            {
                entities.Update(entity);
            }
        }

        public  void Delete(T entity)
        {
            entities.Remove(entity);
        }

        public async Task SaveChanges()
        {
            await _dbcontext.SaveChangesAsync();
        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public T getEntityById(int id)
        {
            return entities.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
