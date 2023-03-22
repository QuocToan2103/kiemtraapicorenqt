using kiemtra_nqtk18b.Model;
using System.Linq.Expressions;

namespace kiemtra_nqtk18b.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Get(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetFilter(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Delete(int id);
    }
}
