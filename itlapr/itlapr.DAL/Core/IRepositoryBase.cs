using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace itlapr.DAL.Core
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        void Save(TEntity[] entities);
        void Update(TEntity entity);
        void Update(TEntity[] entities);
        void Remove(TEntity entity);
        void Remove(TEntity[] entities);
        TEntity GetEntity(int id);
        List<TEntity> GetEntities();
        bool Exists (Expression<Func<TEntity, bool>> predicate);
        void SaveChanges();

    }
}
