using DataAccessLayer.ObjectRelationalMapping;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// DAO <see cref="Subject"/> functionality
    /// </summary>
    public class DAOSubject : DAO<Subject>
    {
        /// <summary>
        /// Class constructor <see cref="DAOSubject"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOSubject(string connectionString) : base(connectionString)
        {
        }

        public override async Task<Subject> IsExistAsync(Subject data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Subject>().FirstOrDefault(g => g.Name == data.Name)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> UpdateAsync(Subject data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        Subject Subject = db.GetTable<Subject>().FirstOrDefault(g => g.Id == data.Id);
                        Subject.Name = data.Name;
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
