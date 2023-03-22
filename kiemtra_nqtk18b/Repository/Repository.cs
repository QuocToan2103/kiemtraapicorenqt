using Microsoft.EntityFrameworkCore;
using kiemtra_nqtk18b.Model;
using System;
using System.Linq.Expressions;

namespace kiemtra_nqtk18b.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public readonly Context _dbContext;
        public Repository(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChangesAsync();
            return Task.CompletedTask;
        }

        public async Task Delete(int id)
        {
            var obj = _dbContext.Set<T>().Where(x => x.Id == id).FirstOrDefault();
            if (obj != null)
            {
                _dbContext.Set<T>().Remove(obj);
                _dbContext.SaveChangesAsync();
            }
        }

        public async Task<T> Get(int id)
        {
            var rs = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return rs;
        }

        public IQueryable<T> GetAll()
        {
            var rs = _dbContext.Set<T>().AsNoTracking();
            return rs;
        }

        public IQueryable<T> GetFilter(Expression<Func<T, bool>> expression)
        {
            var rs = _dbContext.Set<T>().AsNoTracking().Where(expression);
            return rs;
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }

    }
}
