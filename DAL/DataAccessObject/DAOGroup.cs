using DataAccessLayer.ObjectRelationalMapping;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// DAO <see cref="Group"/> functionality
    /// </summary>
    public class DAOGroup : DAO<Group>
    {
        /// <summary>
        /// Class constructor <see cref="DAOGroup"/>
        /// </summary>
        /// <param name="connectionString"></param>
        public DAOGroup(string connectionString) : base(connectionString)
        {
        }

        public override async Task<Group> IsExistAsync(Group data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Group>().FirstOrDefault(g => g.Name == data.Name && g.SpecialtiesID == data.SpecialtiesID)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> UpdateAsync(Group data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        Group group = db.GetTable<Group>().FirstOrDefault(g => g.Id == data.Id);
                        group.Name = data.Name;
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
