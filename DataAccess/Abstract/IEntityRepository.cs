using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        List<T> GetById();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
