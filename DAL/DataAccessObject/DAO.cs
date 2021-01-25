using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// Generic data access object (DAO)
    /// </summary>
    /// <typeparam name="T">Class</typeparam>
    public abstract class DAO<T> : IDAO<T> where T : class
    {
        protected string connectionString;
        public DAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public abstract Task<bool> UpdateAsync(T entity);
        public abstract Task<T> IsExistAsync(T data);

        public async Task<bool> InsertAsync(T data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        db.GetTable<T>().InsertOnSubmit(data); db.SubmitChanges();
                    }).ConfigureAwait(false);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<T> ReadAsync(int id)
        {
            var itemParameter = Expression.Parameter(typeof(T), "item");
            var whereExpression = Expression.Lambda<Func<T, bool>>(Expression.Equal(Expression.Property(itemParameter, "Id"), Expression.Constant(id)), new[] { itemParameter });

            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return db.GetTable<T>().FirstOrDefault(whereExpression);
                }
            }
            catch
            {
                return null;
            }
        }
        public async Task<IEnumerable<T>> ReadAllAsync()
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<T>().ToList()).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var itemParameter = Expression.Parameter(typeof(T), "item");
            var whereExpression = Expression.Lambda<Func<T, bool>>(Expression.Equal(Expression.Property(itemParameter, "Id"), Expression.Constant(id)), new[] { itemParameter });

            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        db.GetTable<T>().DeleteOnSubmit(db.GetTable<T>().FirstOrDefault(whereExpression));
                        db.SubmitChanges();
                    }).ConfigureAwait(false);
                }
                return true;

            }
            catch
            {
                return false;
            }
        }


    }
}
