using CourseProject.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.EntityFramework
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CourseProjectDbContext _dbContext;
        public Repository(CourseProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(T entity)
        {
            var dbSet = _dbContext.Set<T>();
            dbSet.Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            var dbSet = _dbContext.Set<T>();
            dbSet.AddRange(entities);
        }

        public T Get(int id)
        {
            var dbSet = _dbContext.Set<T>();
            var result = dbSet.Find(id);
            return result;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public void Remove(int id)
        {
            var dbSet = _dbContext.Set<T>();
            var entity = dbSet.Find(id);
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            var dbSet = _dbContext.Set<T>();
            _dbContext.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            var dbSet = _dbContext.Set<T>();
            dbSet.Update(entity);
        }
    }
}
