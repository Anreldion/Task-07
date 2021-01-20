using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// DAO <see cref="TestForm"/> functionality
    /// </summary>
    public class DAOTestForm : DAO<TestForm>
    {
        /// <summary>
        /// Class constructor <see cref="DAOTestForm"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOTestForm(string connectionString) : base(connectionString)
        {

        }
    }

}
