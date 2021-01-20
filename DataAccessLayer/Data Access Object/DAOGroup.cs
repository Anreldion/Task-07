using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// DAO <see cref="Group"/> functionality
    /// </summary>
    public class DAOGroup : DAO<Group>
    {
        /// <summary>
        /// Class constructor <see cref="DAOGroup"/>
        /// </summary>
        /// <param name="connectionString"></param>
        public DAOGroup(string connectionString) : base(connectionString)
        {
        }
    }

}
