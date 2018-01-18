using System;
using System.Collections.Generic;
using System.Linq;
using AracYonetim.DAL;

namespace AracYonetim.BLL.Repository
{
    public abstract class RepositoryBase<T, TId> where T : class
    {
        protected static MyContext dbContext;
        public virtual List<T> GetAll()
        {
            try
            {
                dbContext = new MyContext();
                return dbContext.Set<T>().ToList();
            }
            catch
            {
                throw;
            }
        }
        public virtual T GetById(TId id)
        {
            try
            {
                dbContext = new MyContext();
                return dbContext.Set<T>().Find(id);
            }
            catch
            {
                throw;
            }
        }
        public virtual int Insert(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.Set<T>().Add(entity);
                return dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public virtual int Delete(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.Set<T>().Remove(entity);
                return dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public virtual int Update()
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                return dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public  IQueryable<T> Queryable()
        {
            try
            {
                dbContext = new MyContext();
                return dbContext.Set<T>().AsQueryable();
            }
            catch
            {
                throw;
            }
        }
    }
}
