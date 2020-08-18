using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Secretaria.Repository.V2
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T Get(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
    }
}
