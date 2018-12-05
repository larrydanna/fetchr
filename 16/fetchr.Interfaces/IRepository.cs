using System;
using System.Linq;
using System.Linq.Expressions;

namespace fetchr.Interfaces
{
    public interface IRepository
    {
        IQueryable<T> Where<T>(Expression<Func<T, bool>> expression = null) where T : class;

        T Single<T>(Expression<Func<T, bool>> expression) where T : class;

        void Save<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        //IQueryable<T> ExecuteSql<T>(string sql, params object[] parameters) where T : class;

        //IQueryable<T> Include<T>(Expression<Func<T, object>> expression) where T : class;

        //void Dispose();
    }
}
