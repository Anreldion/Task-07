using System.Collections.Generic;
using System.Threading.Tasks;
namespace DataAccessLayer.DataAccessObject
{
    /// <summary>Interface describes CRUD functionality</summary>
    /// <typeparam name="T">ORM model</typeparam>
    public interface IDAO<T>
    {
        /// <summary>
        /// Checking an object for existence.
        /// </summary>
        /// <param name="data">Data object</param>
        /// <returns></returns>
        Task<T> IsExistAsync(T data);
        /// <summary>
        /// Add data to database table.
        /// </summary>
        /// <param name="data">Data object</param>
        /// <returns>true if successful, otherwise false</returns>
        Task<bool> InsertAsync(T data);
        /// <summary>
        /// Get data from a table by ID.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Data(T)</returns>
        Task<T> ReadAsync(int id);
        /// <summary>
        /// Get all data from a table.
        /// </summary>
        /// <returns><IEnumerable<T>></returns>
        Task<IEnumerable<T>> ReadAllAsync();
        /// <summary>
        /// Update a record in a database table.
        /// </summary>
        /// <param name="data">Data object</param>
        /// <returns>true if successful, otherwise false</returns>
        Task<bool> UpdateAsync(T data);
        /// <summary>
        /// Delete record from database table.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>true if successful, otherwise false</returns>
        Task<bool> DeleteAsync(int id);
    }
}





