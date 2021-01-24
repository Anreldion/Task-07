using DataAccessLayer.ObjectRelationalMapping;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{

    /// <summary>
    /// DAO <see cref="Examiner"/> functionality
    /// </summary>
    public class DAOExaminer : IDAO<Examiner>
    {
        string connectionString;
        /// <summary>
        /// Class constructor <see cref="DAOExaminer"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOExaminer(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<Examiner> IsExistAsync(Examiner data)
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
        public async Task<bool> InsertAsync(Examiner data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() => { db.GetTable<Examiner>().InsertOnSubmit(data); db.SubmitChanges(); }).ConfigureAwait(false);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<Examiner> ReadAsync(int id)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Examiner>().FirstOrDefault(g => g.Id == id)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<Examiner>> ReadAllAsync()
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Examiner>().ToList()).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(Examiner data)
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
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() => { db.GetTable<Examiner>().DeleteOnSubmit(db.GetTable<Examiner>().FirstOrDefault(g => g.Id == id)); db.SubmitChanges(); }).ConfigureAwait(false);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }

}
