using DataAccessLayer.ObjectRelationalMapping;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// DAO <see cref="SessionPeriod"/> functionality
    /// </summary>
    public class DAOSessionPeriod : IDAO<SessionPeriod>
    {
        private string connectionString;

        /// <summary>
        /// Class constructor <see cref="DAOSessionPeriod"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOSessionPeriod(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() => { db.GetTable<SessionPeriod>().DeleteOnSubmit(db.GetTable<SessionPeriod>().FirstOrDefault(g => g.Id == id)); db.SubmitChanges(); }).ConfigureAwait(false);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> InsertAsync(SessionPeriod data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() => { db.GetTable<SessionPeriod>().InsertOnSubmit(data); db.SubmitChanges(); }).ConfigureAwait(false);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<SessionPeriod> IsExistAsync(SessionPeriod data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<SessionPeriod>().FirstOrDefault(g => g.Name == data.Name)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<SessionPeriod>> ReadAllAsync()
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<SessionPeriod>().ToList()).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<SessionPeriod> ReadAsync(int id)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<SessionPeriod>().FirstOrDefault(g => g.Id == id)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(SessionPeriod data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        SessionPeriod SessionPeriod = db.GetTable<SessionPeriod>().FirstOrDefault(g => g.Id == data.Id);
                        SessionPeriod.Name = data.Name;
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
