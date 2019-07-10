using Kehstartir.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.EntityFramework
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EntitiesContext entitiesContext;
        public Repository(EntitiesContext entitiesContext)
        {
            this.entitiesContext = entitiesContext;
        }
        public void Add(T entity)
        {
            var dbSet = entitiesContext.Set<T>();
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
            var dbSet = entitiesContext.Set<T>();
            var result = dbSet.Find(id);
            return result;
        }

        public IEnumerable<T> GetAll()
        {
            return entitiesContext.Set<T>();
        }

        public void Remove(int id)
        {
            var dbSet = entitiesContext.Set<T>();
            var entity = dbSet.Find(id);
            dbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            entitiesContext.SaveChanges();
        }

        public void Update(T entity)
        {
            var dbSet = entitiesContext.Set<T>();
            dbSet.Update(entity);
        }
    }
}
