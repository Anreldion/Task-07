using DataAccessLayer.ObjectRelationalMapping;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{

    /// <summary>
    /// DAO <see cref="Examiners"/> functionality
    /// </summary>
    public class DAOExaminer : IDAO<Examiners>
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

        public async Task<Examiners> IsExistAsync(Examiners data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Examiners>().FirstOrDefault(g => 
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
        public async Task<bool> InsertAsync(Examiners data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() => { db.GetTable<Examiners>().InsertOnSubmit(data); db.SubmitChanges(); }).ConfigureAwait(false);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<Examiners> ReadAsync(int id)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Examiners>().FirstOrDefault(g => g.Id == id)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<Examiners>> ReadAllAsync()
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Examiners>().ToList()).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(Examiners data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        Examiners Examiners = db.GetTable<Examiners>().FirstOrDefault(g => g.Id == data.Id);
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
                    await Task.Run(() => { db.GetTable<Examiners>().DeleteOnSubmit(db.GetTable<Examiners>().FirstOrDefault(g => g.Id == id)); db.SubmitChanges(); }).ConfigureAwait(false);
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
