using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// Универсальный объект доступа к данным (DAO)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class DAO<T> : IDAO<T> where T : class
    {
        DataContext db;

        public DAO(string connectionString)
        {
            db = new DataContext(connectionString);
            db.DeferredLoadingEnabled = false;
        }

        public abstract Task<bool> IsExistAsync(T data);
        public abstract Task<bool> UpdateAsync(T entity);
        public async Task<bool> InsertAsync(T data)
        {
            try
            {
                await Task.Run(() =>
                {
                    db.GetTable<T>().InsertOnSubmit(data); db.SubmitChanges();
                }).ConfigureAwait(false);

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
                return db.GetTable<T>().FirstOrDefault(whereExpression);
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
                return await Task.Run(() => db.GetTable<T>().ToList()).ConfigureAwait(false);
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
                await Task.Run(() =>
                {
                    db.GetTable<T>().DeleteOnSubmit(db.GetTable<T>().FirstOrDefault(whereExpression));
                    db.SubmitChanges();
                }).ConfigureAwait(false);
                return true;

            }
            catch
            {
                return false;
            }
        }

        Task<T> IDAO<T>.IsExistAsync(T data)
        {
            throw new NotImplementedException();
        }
    }
}
