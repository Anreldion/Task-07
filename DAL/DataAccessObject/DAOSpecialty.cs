using DataAccessLayer.ObjectRelationalMapping;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;
namespace DataAccessLayer.DataAccessObject
{

    /// <summary>
    /// DAO <see cref="Specialty"/> functionality
    /// </summary>
    public class DAOSpecialty : DAO<Specialty>
    {
        /// <summary>
        /// Class constructor <see cref="DAOSpecialty"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOSpecialty(string connectionString) : base(connectionString)
        {
        }

        public override async Task<Specialty> IsExistAsync(Specialty data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Specialty>().FirstOrDefault(g => g.Name == data.Name)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> UpdateAsync(Specialty data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        Specialty Specialty = db.GetTable<Specialty>().FirstOrDefault(g => g.Id == data.Id);
                        Specialty.Name = data.Name;
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
