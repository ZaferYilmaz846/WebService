using Infrastructure.DataAccess.Repositories.Abstract;
using Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace WebService.DataAccessLayer.Repositories.Abstract
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includeList)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> dbSet = context.Set<TEntity>();
                if (includeList != null)
                {
                    foreach (var item in includeList)
                    {
                        dbSet = dbSet.Include(item);
                    }
                }

                if (filter != null)
                {
                    dbSet = dbSet.Where(filter);
                }
                return dbSet.ToList();
                //return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] includeList)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> dbSet = context.Set<TEntity>();
                if (includeList != null)
                {
                    foreach (var item in includeList)
                    {
                        dbSet = dbSet.Include(item);
                    }
                }
                if (filter != null)
                {
                    dbSet = dbSet.Where(filter);
                }
                return dbSet.SingleOrDefault();
            }
        }
        public TEntity Insert(TEntity entity, params string[] includeList)
        {
            using (TContext context = new TContext())
            {
                EntityEntry<TEntity> insertedEntity = context.Set<TEntity>().Add(entity);
                context.SaveChanges();
                return insertedEntity.Entity;
            }
        }
        public void Delete(TEntity entity, params string[] includeList)
        {
            using (TContext context = new TContext())
            {
                EntityEntry<TEntity> deletedEntity = context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public TEntity Update(TEntity entity, params string[] includeList)
        {
            using (TContext context = new TContext())
            {
                EntityEntry<TEntity> updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
                return updatedEntity.Entity;
            }
        }
    }
}
