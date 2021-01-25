using DataAccessLayer.ObjectRelationalMapping;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// DAO <see cref="Result"/> functionality
    /// </summary>
    public class DAOResult : DAO<Result>
    {
        /// <summary>
        /// Class constructor <see cref="DAOResult"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOResult(string connectionString) : base(connectionString)
        {
        }

        public override async Task<Result> IsExistAsync(Result data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() =>
                    db.GetTable<Result>().FirstOrDefault(g =>
                    g.Mark == data.Mark &&
                    g.SubjectId == data.SubjectId &&
                    g.SessionId == data.SessionId &&
                    g.StudentId == data.StudentId)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> UpdateAsync(Result data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        Result Result = db.GetTable<Result>().FirstOrDefault(g => g.Id == data.Id);
                        Result.Mark = data.Mark;
                        Result.SessionId = data.SessionId;
                        Result.StudentId = data.StudentId;
                        Result.SubjectId = data.SubjectId;
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
