using DataAccessLayer.ObjectRelationalMapping;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// DAO <see cref="Schedule"/> functionality
    /// </summary>
    public class DAOSchedule : DAO<Schedule>
    {
        /// <summary>
        /// Class constructor <see cref="DAOSchedule"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOSchedule(string connectionString) : base(connectionString)
        {
        }

        public override async Task<Schedule> IsExistAsync(Schedule data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() =>
                    db.GetTable<Schedule>().FirstOrDefault(g =>
                    g.GroupId == data.GroupId &&
                    g.Date == data.Date &&
                    g.ExaminerID == data.ExaminerID &&
                    g.SubjectId == data.SubjectId &&
                    g.TestFormId == data.TestFormId &&
                    g.SessionId == data.SessionId)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> UpdateAsync(Schedule data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        Schedule Schedule = db.GetTable<Schedule>().FirstOrDefault(g => g.Id == data.Id);
                        Schedule.Date = data.Date;
                        Schedule.GroupId = data.GroupId;
                        Schedule.SessionId = data.SessionId;
                        Schedule.SubjectId = data.SubjectId;
                        Schedule.TestFormId = data.TestFormId;
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
