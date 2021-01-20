using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// DAO <see cref="Gender"/> functionality
    /// </summary>
    public class DAOGender : DAO<Gender>
    {
        /// <summary>
        /// Class constructor <see cref="DAOGender"/>
        /// </summary>
        /// <param name="connectionString"></param>
        public DAOGender(string connectionString) : base(connectionString)
        {
        }
    }

}
