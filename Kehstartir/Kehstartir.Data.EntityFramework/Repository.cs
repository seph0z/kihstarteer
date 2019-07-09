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

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
