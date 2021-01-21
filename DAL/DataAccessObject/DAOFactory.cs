using DataAccessLayer.ObjectRelationalMapping;

namespace DataAccessLayer.DataAccessObject
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
        public IDAO<EducationForm> GetEducationForm()
        {
            return new DAOEducationForm(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Gender"/> object
        /// </summary>
        /// <returns><see cref="DAO{Gender}"/> object</returns>
        public IDAO<Gender> GetGender()
        {
            return new DAOGender(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Group"/> object
        /// </summary>
        /// <returns><see cref="DAO{Group}"/> object</returns>
        public IDAO<Group> GetGroup()
        {
            return new DAOGroup(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Specialty"/> object
        /// </summary>
        /// <returns><see cref="DAO{Specialty}"/> object</returns>
        public IDAO<Specialty> GetSpecialty()
        {
            return new DAOSpecialty(connectionString);
        }

        /// <summary>
        /// Getting DAO <see cref="Result"/> object
        /// </summary>
        /// <returns><see cref="DAO{Result}"/> object</returns>
        public IDAO<Result> GetResult()
        {
            return new DAOResult(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Schedule"/> object
        /// </summary>
        /// <returns><see cref="DAO{Schedule}"/> object</returns>
        public IDAO<Schedule> GetSchedule()
        {
            return new DAOSchedule(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Examiners"/> object
        /// </summary>
        /// <returns><see cref="DAO{Examiners}"/> object</returns>
        public IDAO<Examiners> GetExaminer()
        {
            return new DAOExaminer(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Session"/> object
        /// </summary>
        /// <returns><see cref="DAO{Session}"/> object</returns>
        public IDAO<Session> GetSession()
        {
            return new DAOSession(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="SessionPeriod"/> object
        /// </summary>
        /// <returns><see cref="DAO{SessionPeriod}"/> object</returns>
        public IDAO<SessionPeriod> GetSessionPeriod()
        {
            return new DAOSessionPeriod(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Student"/> object
        /// </summary>
        /// <returns><see cref="DAO{Student}"/> object</returns>
        public IDAO<Student> GetStudent()
        {
            return new DAOStudent(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="Subject"/> object
        /// </summary>
        /// <returns><see cref="DAO{Subject}"/> object</returns>
        public IDAO<Subject> GetSubject()
        {
            return new DAOSubject(connectionString);
        }
        /// <summary>
        /// Getting DAO <see cref="TestForm"/> object
        /// </summary>
        /// <returns><see cref="DAO{TestForm}"/> object</returns>
        public IDAO<TestForm> GetTestForm()
        {
            return new DAOTestForm(connectionString);
        }
    }
}
