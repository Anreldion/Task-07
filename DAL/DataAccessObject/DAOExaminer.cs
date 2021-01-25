using DataAccessLayer.ObjectRelationalMapping;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{

    /// <summary>
    /// DAO <see cref="Examiner"/> functionality
    /// </summary>
    public class DAOExaminer : DAO<Examiner>
    {
        /// <summary>
        /// Class constructor <see cref="DAOExaminer"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOExaminer(string connectionString) : base(connectionString)
        {
        }

        public override async Task<Examiner> IsExistAsync(Examiner data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Examiner>().FirstOrDefault(g =>
                    g.Name == data.Name &&
                    g.Surname == data.Surname &&
                    g.MiddleName == data.MiddleName)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> UpdateAsync(Examiner data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        Examiner Examiners = db.GetTable<Examiner>().FirstOrDefault(g => g.Id == data.Id);
                        Examiners.Name = data.Name;
                        Examiners.Surname = data.Surname;
                        Examiners.MiddleName = data.MiddleName;
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
