using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// DAO <see cref="Schedule"/> functionality
    /// </summary>
    public class DAOSchedule : DAO<Schedule>
    {
        /// <summary>
        /// Class constructor <see cref="DAOSchedule"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOSchedule(string connectionString) : base(connectionString)
        {
        }
    }

}
