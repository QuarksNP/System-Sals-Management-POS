using itlapr.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace itlapr.DAL.Core
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ItlaContext itlaContext;
        private DbSet<TEntity> Entities;

        public RepositoryBase(ItlaContext itlaContext)
        {
            this.itlaContext = itlaContext;
            this.Entities = this.itlaContext.Set<TEntity>();
        }
        public virtual bool Exists(Expression<Func<TEntity, bool>> predicate)
        {
            return this.Entities.Any(predicate);
        }

        public virtual List<TEntity> GetEntities()
        {
            return this.Entities.ToList();
        }

        public virtual TEntity GetEntity(int id)
        {
            return this.Entities.Find(id);
        }

        public virtual void Remove(TEntity entity)
        {
           this.Entities.Remove(entity);
        }

        public virtual void Remove(TEntity[] entities)
        {
            this.Entities.RemoveRange(entities);
        }

        public virtual void Save(TEntity entity)
        {
            this.Entities.Add(entity);
        }

        public virtual void Save(TEntity[] entities)
        {
            this.Entities.AddRange(entities);
        }

        public void SaveChanges()
        {
            this.itlaContext.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            this.itlaContext.Update(entity);
        }

        public virtual void Update(TEntity[] entities)
        {
            this.itlaContext.UpdateRange(entities);
        }
    }
}
