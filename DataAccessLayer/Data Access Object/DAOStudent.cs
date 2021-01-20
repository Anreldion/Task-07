using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// DAO <see cref="Student"/> functionality
    /// </summary>
    public class DAOStudent : DAO<Student>
    {
        /// <summary>
        /// Class constructor <see cref="DAOEducationForm"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOStudent(string connectionString) : base(connectionString)
        {
        }
    }

}
