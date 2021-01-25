using DataAccessLayer.ObjectRelationalMapping;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;
namespace DataAccessLayer.DataAccessObject
{

    /// <summary>
    /// DAO <see cref="Gender"/> functionality
    /// </summary>
    public class DAOGender : IDAO<Gender>
    {
        string connectionString;
        /// <summary>
        /// Class constructor <see cref="DAOGender"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOGender(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<Gender> IsExistAsync(Gender data)
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
        public async Task<bool> InsertAsync(Gender data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() => { db.GetTable<Gender>().InsertOnSubmit(data); db.SubmitChanges(); }).ConfigureAwait(false);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<Gender> ReadAsync(int id)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Gender>().FirstOrDefault(g => g.Id == id)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<Gender>> ReadAllAsync()
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Gender>().ToList()).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(Gender data)
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
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() => 
                    { 
                        db.GetTable<Gender>().DeleteOnSubmit(db.GetTable<Gender>().FirstOrDefault(g => g.Id == id)); 
                        db.SubmitChanges(); 
                    }).ConfigureAwait(false);
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
