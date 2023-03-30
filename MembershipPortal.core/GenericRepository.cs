using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.core
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected DbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context), $"The parameter dbContextCreator cannot be null");

            this._context = context;
            this._dbSet = _context.Set<T>();
        }

        public bool Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity), $"The new Entity parameter cannot be null");

            try
            {
                _dbSet.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual async Task<bool> AddAsync(T entity)
        {
            Add(entity);
            await SaveAsync();
            return true;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            if (entities == null) throw new ArgumentNullException(nameof(entities), $"The entities parameter cannot be null");

            try
            {
                _dbSet.AddRange(entities);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual async Task AddRangeAsync(IEnumerable<T> entities)
        {
            AddRange(entities);
            await SaveAsync();
        }

        public bool Any(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null) return _dbSet.Any();
            return _dbSet.Any(predicate);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null) return await _dbSet.AnyAsync();
            return await _dbSet.AnyAsync(predicate);
        }

        public virtual long Count(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null) return _dbSet.LongCount();
            return _dbSet.LongCount(predicate);
        }

        public virtual async Task<long> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null) return await _dbSet.LongCountAsync();
            return await _dbSet.LongCountAsync(predicate);
        }

        public virtual bool Delete(T obj)
        {
            _dbSet.Remove(obj);
            return true;
        }

        public virtual bool Delete(Expression<Func<T, bool>> predicate)
        {
            var obj = GetSingleBy(predicate);
            if (obj != null)
            {
                _dbSet.Remove(obj);
                return true;
            }
            else throw new Exception($"object does not exist");
        }

        public virtual async Task DeleteAsync(T obj)
        {
            Delete(obj);
            await SaveAsync();
        }

        public virtual async Task DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            Delete(predicate);
            await SaveAsync();
        }

        public virtual bool DeleteById(object id)
        {
            var obj = _dbSet.Find(id);
            if (obj != null)
            {
                _dbSet.Remove(obj);
                return true;
            }
            else throw new Exception($"object with id {id} does not exist");
        }

        public virtual async Task DeleteByIdAsync(object id)
        {
            DeleteById(id);
            await SaveAsync();
        }

        public virtual bool DeleteRange(IEnumerable<T> records)
        {
            _dbSet.RemoveRange(records);
            return true;
        }

        public virtual bool DeleteRange(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> records = from x in _dbSet.Where<T>(predicate) select x;

            if (records.Count() > 0)
            {
                _dbSet.RemoveRange(records);
            }

            return true;
        }

        public virtual async Task DeleteRangeAsync(IEnumerable<T> records)
        {
            DeleteRange(records);
            await SaveAsync();
        }

        public virtual async Task DeleteRangeAsync(Expression<Func<T, bool>> predicate)
        {
            DeleteRange(predicate);
            await SaveAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetBy(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? skip = default(int?), int? take = default(int?), params string[] includeProperties)
        {
            IQueryable<T> query = ConstructQuery(predicate, orderBy, skip, take, includeProperties);

            return await query.ToListAsync();
        }

        public async Task<T> GetByFirstOrDefault(Expression<Func<T, bool>> predicate, params string[] includeProperties)
        {
            try
            {
                IQueryable<T> query = ConstructQuery(predicate, null, null, null, includeProperties);

                return await query.FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> GetBySingleOrDefault(Expression<Func<T, bool>> predicate, params string[] includeProperties)
        {
            IQueryable<T> query = ConstructQuery(predicate, null, null, null, includeProperties);

            return await query.SingleOrDefaultAsync();
        }

        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual async Task<T> GetByIdAsync(object id)
        {
            try
            {

                return await _dbSet.FindAsync(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public T GetSingleBy(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public virtual async Task<T> GetSingleByAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public T Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry<T>(obj).State = EntityState.Modified;
            return obj;
        }

        public virtual async Task<T> UpdateAsync(T obj)
        {
            Update(obj);
            await SaveAsync();
            return obj;
        }


        private IQueryable<T> ConstructQuery(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, int? skip, int? take, params string[] includeProperties)
        {
            IQueryable<T> query = _dbSet;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            for (int i = 0; i < includeProperties.Length; i++)
            {
                query = query.Include(includeProperties[i]);
            }

            if (skip != null)
            {
                query = query.Skip(skip.Value);
            }

            if (take != null)
            {
                query = query.Take(take.Value);
            }

            return query;
        }
    }
}
