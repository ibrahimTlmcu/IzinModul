using IzinModul.DataContext.Contracts;
using IzinModul.DataContext.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IzinModul.DataContext.Implementaion
{
    public class Repository<T> : IRepositoryBase<T> where T : class, new()
    {

        private readonly IzinModulDataContext _ctx;
        internal DbSet<T> dbSet;

        public Repository(IzinModulDataContext ctx)
        {
            _ctx = ctx;
            this.dbSet = _ctx.Set<T>();
        }

        //Genel Tipte veriyi kayit eder. 

        public void Add(T entity)
        {
           dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if(filter != null)
            {
                query = query.Where(filter);
            }
            if(includeProperties != null)
            {
                foreach(var item in includeProperties.Split(new char[] { ','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }

            if(orderBy != null)
            {
                return orderBy(query);
            }
            return query;
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
