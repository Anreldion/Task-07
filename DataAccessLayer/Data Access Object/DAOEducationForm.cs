using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// DAO <see cref="EducationForm"/> functionality
    /// </summary>
    public class DAOEducationForm : DAO<EducationForm>
    {
        /// <summary>
        /// Class constructor <see cref="DAOEducationForm"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAOEducationForm(string connectionString) : base(connectionString)
        {
        }
    }

}
