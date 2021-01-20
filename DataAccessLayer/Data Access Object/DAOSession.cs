using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// DAO <see cref="Session"/> functionality
    /// </summary>
    public class DAOSession : DAO<Session>
    {
        /// <summary>
        /// Class constructor <see cref="DAOSession"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOSession(string connectionString) : base(connectionString)
        {

        }
    }

}
