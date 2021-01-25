using DataAccessLayer.ObjectRelationalMapping;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;
namespace DataAccessLayer.DataAccessObject
{

    /// <summary>
    /// DAO <see cref="Gender"/> functionality
    /// </summary>
    public class DAOGender : DAO<Gender> //: IDAO<Gender>
    {
        /// <summary>
        /// Class constructor <see cref="DAOGender"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOGender(string connectionString) : base(connectionString)
        {
        }

        public override async Task<Gender> IsExistAsync(Gender data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Gender>().FirstOrDefault(g => g.Name == data.Name)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> UpdateAsync(Gender data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        Gender genders = db.GetTable<Gender>().FirstOrDefault(g => g.Id == data.Id);
                        genders.Name = data.Name;
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
