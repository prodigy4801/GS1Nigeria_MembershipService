using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.core
{
    public interface IGenericRepository<T> where T : class
    {
        bool Add(T entity);
        void AddRange(IEnumerable<T> entities);
        Task<bool> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T GetSingleBy(Expression<Func<T, bool>> predicate);
        Task<T> GetSingleByAsync(Expression<Func<T, bool>> predicate);
        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate = null);
        IEnumerable<T> GetBy(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? skip = null, int? take = null, params string[] includeProperties);

        long Count(Expression<Func<T, bool>> predicate = null);
        Task<long> CountAsync(Expression<Func<T, bool>> predicate = null);

        T Update(T obj);
        Task<T> UpdateAsync(T obj);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate = null);
        bool Any(Expression<Func<T, bool>> predicate = null);

        bool Delete(T obj);
        Task DeleteAsync(T obj);
        bool Delete(Expression<Func<T, bool>> predicate);
        Task DeleteAsync(Expression<Func<T, bool>> predicate);
        bool DeleteRange(IEnumerable<T> records);
        Task DeleteRangeAsync(IEnumerable<T> records);
        bool DeleteRange(Expression<Func<T, bool>> predicate);
        Task DeleteRangeAsync(Expression<Func<T, bool>> predicate);
        bool DeleteById(object id);
        Task DeleteByIdAsync(object id);

        int Save();
        Task<int> SaveAsync();
    }
}
