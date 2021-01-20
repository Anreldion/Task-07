using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// DAO <see cref="SessionPeriod"/> functionality
    /// </summary>
    public class DAOSessionPeriod : DAO<SessionPeriod>
    {
        /// <summary>
        /// Class constructor <see cref="DAOSessionPeriod"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOSessionPeriod(string connectionString) : base(connectionString)
        {
        }
    }

}
