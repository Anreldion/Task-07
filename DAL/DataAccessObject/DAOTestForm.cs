using DataAccessLayer.ObjectRelationalMapping;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// DAO <see cref="TestForm"/> functionality
    /// </summary>
    public class DAOTestForm : DAO<TestForm>
    {
        /// <summary>
        /// Class constructor <see cref="DAOTestForm"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOTestForm(string connectionString) : base(connectionString)
        {
        }

        public override async Task<TestForm> IsExistAsync(TestForm data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<TestForm>().FirstOrDefault(g => g.Name == data.Name)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> UpdateAsync(TestForm data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        TestForm TestForm = db.GetTable<TestForm>().FirstOrDefault(g => g.Id == data.Id);
                        TestForm.Name = data.Name;
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
