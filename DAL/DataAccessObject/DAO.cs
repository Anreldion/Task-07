using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    class DAO<T> : IDAO<T> where T : class
    {
        DataContext db;

        public DAO(string connectionString)
        {
            db = new DataContext(connectionString);
            db.DeferredLoadingEnabled = false;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            try
            {
                await Task.Run(() => { db.GetTable<T>().DeleteOnSubmit(entity); db.SubmitChanges(); }).ConfigureAwait(false);
                return true;

            }
            catch
            {
                return false;
            }
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(T entity)
        {
            try
            {
                await Task.Run(() => { db.GetTable<T>().InsertOnSubmit(entity); db.SubmitChanges(); }).ConfigureAwait(false);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> IsExistAsync(T data)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<T>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> ReadAsync(T entity)
        {
            try
            {
                //return await Task.Run(() => db.GetTable<T>().  FirstOrDefault(g => g.Id == id)).ConfigureAwait(false);
                return null;
            }
            catch
            {
                return null;
            }
        }

        public Task<T> ReadAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            try
            {
                await Task.Run(() => { db.GetTable<T>().Attach(entity,false); db.SubmitChanges(); }).ConfigureAwait(false);
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
