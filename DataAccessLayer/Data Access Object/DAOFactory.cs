using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// Factory to create Data Access Object.
    /// </summary>
    public class DAOFactory
    {
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        private DAOFactory()
        {
        }

        /// <summary>
        /// Create class object.
        /// </summary>
        private static DAOFactory factory;

        /// <summary>
        /// Database connection string
        /// </summary>
        private static string connectionString;

        /// <summary>Class constructor<see cref="DAOFactory"/></summary>
        /// <param name="connectionString">Database connection string</param>
        /// <returns><see cref="DAOFactory"/> object</returns>
        public static DAOFactory GetInstance(string connectionString)
        {
            if (factory == null)
            {
                factory = new DAOFactory();
                DAOFactory.connectionString = connectionString;
            }
            return factory;
        }

        /// <summary>
        /// Getting DAO <see cref="EducationForm"/> object
        /// </summary>
        /// <returns><see cref="DAO{EducationForm}"/> object</returns>
        public DAO<EducationForm> GetEducationForm()
        {
            return new DAOEducationForm(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Gender"/> object
        /// </summary>
        /// <returns><see cref="DAO{Gender}"/> object</returns>
        public DAO<Gender> GetGender()
        {
            return new DAOGender(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Group"/> object
        /// </summary>
        /// <returns><see cref="DAO{Group}"/> object</returns>
        public DAO<Group> GetGroup()
        {
            return new DAOGroup(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Result"/> object
        /// </summary>
        /// <returns><see cref="DAO{Result}"/> object</returns>
        public DAO<Result> GetResult()
        {
            return new DAOResult(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Schedule"/> object
        /// </summary>
        /// <returns><see cref="DAO{Schedule}"/> object</returns>
        public DAO<Schedule> GetSchedule()
        {
            return new DAOSchedule(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Session"/> object
        /// </summary>
        /// <returns><see cref="DAO{Session}"/> object</returns>
        public DAO<Session> GetSession()
        {
            return new DAOSession(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="SessionPeriod"/> object
        /// </summary>
        /// <returns><see cref="DAO{SessionPeriod}"/> object</returns>
        public DAO<SessionPeriod> GetSessionPeriod()
        {
            return new DAOSessionPeriod(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Student"/> object
        /// </summary>
        /// <returns><see cref="DAO{Student}"/> object</returns>
        public DAO<Student> GetStudent()
        {
            return new DAOStudent(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Subject"/> object
        /// </summary>
        /// <returns><see cref="DAO{Subject}"/> object</returns>
        public DAO<Subject> GetSubject()
        {
            return new DAOSubject(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="TestForm"/> object
        /// </summary>
        /// <returns><see cref="DAO{TestForm}"/> object</returns>
        public DAO<TestForm> GetTestForm()
        {
            return new DAOTestForm(connectionString);
        }
    }
}
