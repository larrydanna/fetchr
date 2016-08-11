

using System;
using System.Linq;
using System.Linq.Expressions;
using fetchr.Interfaces;

namespace fetchr.Data.Providers
{
    public class TestRepository : IRepository
    {
        private TestContext _context;

        public TestRepository(TestContext context)
        {
            _context = context;
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
        }

        public void Save<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
        }

        public T Single<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return _context.Set<T>().AsQueryable().Where(expression).SingleOrDefault();
        }

        public IQueryable<T> Where<T>(Expression<Func<T, bool>> expression = null) where T : class
        {
            return _context.Set<T>().AsQueryable().Where(expression);
        }
    }
}
