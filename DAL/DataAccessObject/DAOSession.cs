using DataAccessLayer.ObjectRelationalMapping;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// DAO <see cref="Session"/> functionality
    /// </summary>
    public class DAOSession : DAO<Session>
    {
        /// <summary>
        /// Class constructor <see cref="DAOSession"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOSession(string connectionString) : base(connectionString)
        {
        }

        public override async Task<Session> IsExistAsync(Session data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() =>
                    db.GetTable<Session>().FirstOrDefault(g =>
                    g.DateFrom == data.DateFrom &&
                    g.DateTo == data.DateTo &&
                    g.SessionPeriodId == data.SessionPeriodId)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> UpdateAsync(Session data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        Session Session = db.GetTable<Session>().FirstOrDefault(g => g.Id == data.Id);
                        Session.DateFrom = data.DateFrom;
                        Session.DateTo = data.DateTo;
                        Session.SessionPeriodId = data.SessionPeriodId;
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
