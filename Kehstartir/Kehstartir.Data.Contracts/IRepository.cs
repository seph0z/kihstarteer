using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Remove(int id);
        void SaveChanges();
    }
}
