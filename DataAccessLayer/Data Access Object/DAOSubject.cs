using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// DAO <see cref="Subject"/> functionality
    /// </summary>
    public class DAOSubject : DAO<Subject>
    {
        /// <summary>
        /// Class constructor <see cref="DAOSubject"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOSubject(string connectionString) : base(connectionString)
        {
        }
    }

}
