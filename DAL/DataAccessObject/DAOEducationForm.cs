using DataAccessLayer.ObjectRelationalMapping;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// DAO <see cref="EducationForm"/> functionality
    /// </summary>
    public class DAOEducationForm : DAO<EducationForm>
    {
        /// <summary>
        /// Class constructor <see cref="DAOEducationForm"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOEducationForm(string connectionString) : base(connectionString)
        {
        }

        public override async Task<EducationForm> IsExistAsync(EducationForm data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<EducationForm>().FirstOrDefault(g => g.Name == data.Name)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> UpdateAsync(EducationForm data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        EducationForm educationForm = db.GetTable<EducationForm>().FirstOrDefault(g => g.Id == data.Id);
                        educationForm.Name = data.Name;
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
