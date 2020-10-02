using Microsoft.EntityFrameworkCore;
using Padronize.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padronize.Repositories
{
    public class Repository<TDbContext> : IRepository where TDbContext : DbContext
    {
        protected TDbContext dbContext;

        public Repository(TDbContext context)
        {
            dbContext = context;
        }

        public T Create<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Add(entity);

            _ =  this.dbContext.SaveChanges();
            return entity;
        }

        public void Delete<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Remove(entity);
            this.dbContext.SaveChanges();
        }

        public  List<T> FindAll<T>(string entitys="") where T : class
        {
            if(!String.IsNullOrEmpty(entitys))
                return  this.dbContext.Set<T>().Include(entitys).ToList();
                return this.dbContext.Set<T>().ToList();


        }

        public T FindById<T>(int id, string entitys) where T : class
        {
            return  this.dbContext.Set<T>().Find(id);

        }

     

        public void Update<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Update(entity);

            _ =  this.dbContext.SaveChangesAsync();
        }
    }
}