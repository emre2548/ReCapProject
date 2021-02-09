using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Entities;
using System.Linq;
using System.Linq.Expressions;


namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepostoryBase<TEntity,TContext>: IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entitiy)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entitiy);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entitiy)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entitiy);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entitiy)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entitiy);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        List<TEntity> IEntityRepository<TEntity>.GetById()
        {
            throw new NotImplementedException();
        }
    }
}
