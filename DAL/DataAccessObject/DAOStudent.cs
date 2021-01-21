using DataAccessLayer.ObjectRelationalMapping;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObject
{
    /// <summary>
    /// DAO <see cref="Student"/> functionality
    /// </summary>
    public class DAOStudent : IDAO<Student>
    {
        private string connectionString;

        /// <summary>
        /// Class constructor <see cref="DAOEducationForm"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOStudent(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() => { db.GetTable<Student>().DeleteOnSubmit(db.GetTable<Student>().FirstOrDefault(g => g.Id == id)); db.SubmitChanges(); }).ConfigureAwait(false);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> InsertAsync(Student data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() => { db.GetTable<Student>().InsertOnSubmit(data); db.SubmitChanges(); }).ConfigureAwait(false);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<Student> IsExistAsync(Student data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() =>
                    db.GetTable<Student>().FirstOrDefault(g =>
                    g.Surname == data.Surname &&
                    g.MiddleName == data.MiddleName &&
                    g.DateofBirth == data.DateofBirth &&
                    g.EducationFormId == data.EducationFormId &&
                    g.GenderId == data.GenderId &&
                    g.GroupId == data.GroupId &&
                    g.Name == data.Name)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<Student>> ReadAllAsync()
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Student>().ToList()).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<Student> ReadAsync(int id)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    return await Task.Run(() => db.GetTable<Student>().FirstOrDefault(g => g.Id == id)).ConfigureAwait(false);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(Student data)
        {
            try
            {
                using (DataContext db = new DataContext(connectionString))
                {
                    await Task.Run(() =>
                    {
                        Student Student = db.GetTable<Student>().FirstOrDefault(g => g.Id == data.Id);
                        Student.Name = data.Name;
                        Student.Surname = data.Surname;
                        Student.MiddleName = data.MiddleName;
                        Student.DateofBirth = data.DateofBirth;
                        Student.EducationFormId = data.EducationFormId;
                        Student.GenderId = data.GenderId;
                        Student.GroupId = data.GroupId;
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
