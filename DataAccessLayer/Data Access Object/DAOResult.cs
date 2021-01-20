using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// DAO <see cref="Result"/> functionality
    /// </summary>
    public class DAOResult : DAO<Result>
    {
        /// <summary>
        /// Class constructor <see cref="DAOResult"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOResult(string connectionString) : base(connectionString)
        {
        }
    }

}
