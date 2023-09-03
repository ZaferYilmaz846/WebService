using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Infrastructure.DataAccess.Repositories.Abstract
{
    public interface IGenericRepository<TEntity>
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includeList);
        TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] includeList);
        TEntity Insert(TEntity entity, params string[] includeList);
        void Delete(TEntity entity, params string[] includeList);
        TEntity Update(TEntity entity, params string[] includeList);
    }
}
