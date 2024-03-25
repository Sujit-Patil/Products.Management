using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace ProductsManagement.Data.Interfaces
{
    /// <summary>
    /// Base Repository Interface.
    /// </summary>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Add Entity.
        /// </summary>
        /// <param name="toAdd"></param>
        /// <returns></returns>
        Task AddAsync(T toAdd);
        
        /// <summary>
        /// Update Entity.
        /// </summary>
        /// <param name="toUpdate"></param>
        /// <returns></returns>
        public Task<T> UpdateAsync(T toUpdate);

        /// <summary>
        /// Delete Entity.
        /// </summary>
        /// <param name="toDelete"></param>
        /// <returns></returns>
        public void Delete(T toDelete);

        /// <summary>
        /// Get Entity.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<T> GetAsync(Expression<Func<T, bool>> filter);

        /// <summary>
        /// Get all items from expression and include data from the Dbcontext.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll
            (string? includeProperties = null);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<int> CompleteAsync();

        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> filter);
    }
}
