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

//del
//https://overcoder.net/q/766299/%D0%BA%D0%B0%D0%BA-%D1%81%D0%BE%D0%B7%D0%B4%D0%B0%D1%82%D1%8C-%D0%BC%D0%B5%D1%82%D0%BE%D0%B4%D1%8B-crud-%D0%B4%D0%BB%D1%8F-%D1%83%D0%BD%D0%B8%D0%B2%D0%B5%D1%80%D1%81%D0%B0%D0%BB%D1%8C%D0%BD%D0%BE%D0%B3%D0%BE-%D0%BE%D0%B1%D1%8A%D0%B5%D0%BA%D1%82%D0%B0-%D0%B4%D0%BE%D1%81%D1%82%D1%83%D0%BF%D0%B0-%D0%BA-%D0%B4%D0%B0%D0%BD%D0%BD%D1%8B%D0%BC-dao-%D1%81
//https://www.codeproject.com/Articles/26667/Implementing-the-Repository-Pattern-with-LINQ-to-S
//
//
//




