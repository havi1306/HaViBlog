using System;
using System.Linq;
using System.Linq.Expressions;

namespace HaViBlog.Infrastructure.Interface
{
    public interface IReadRepository<T> where T : class
    {
        //T FindById(K id, params Expression<Func<T, object>>[] includeProperties);

        T FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
    }
}