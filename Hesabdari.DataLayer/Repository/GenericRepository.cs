using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdari.DataLayer.Services
{
    public class GenericRepository<TEntity> where TEntity:class
    {
        private Hesabdari_DBEntities db;
        private DbSet<TEntity> dbSet;

        public GenericRepository(Hesabdari_DBEntities context)
        {
            db = context;
            dbSet = db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where=null)
        {
            IQueryable<TEntity> query = dbSet;
            if (where!=null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }
        
        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
         
        public virtual void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(object id)
        {
            Delete(dbSet.Find(id));
        }
    }
}
