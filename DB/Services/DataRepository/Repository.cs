using DB.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.DataRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(TEntity tEntity)
        {
            _dbContext.Set<TEntity>().Add(tEntity);
        }

        public void AddRange(IEnumerable<TEntity> tEntity)
        {
            _dbContext.Set<TEntity>().AddRange(tEntity);
        }
        public IQueryable<TEntity> FindAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public Task<TEntity> FindById(int id)
        {
            return _dbContext.Set<TEntity>().FindAsync(id);
        }

        public void Remove(TEntity tEntity)
        {
            _dbContext.Set<TEntity>().Remove(tEntity);
        }

        public void RemoveRange(IEnumerable<TEntity> tEntity)
        {
            _dbContext.Set<TEntity>().RemoveRange(tEntity);
        }

    }
}
