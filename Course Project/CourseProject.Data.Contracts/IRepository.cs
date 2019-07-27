using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(int id);
        void RemoveRange(IEnumerable<T> entities);
        void SaveChanges();
    }
}
