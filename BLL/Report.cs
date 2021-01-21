using DataAccessLayer.DataAccessObject;
using DataAccessLayer.ObjectRelationalMapping;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Abstract class. Contains information about all data in a database table
    /// </summary>
    public abstract class Report
    {
        /// <summary>
        /// Class constructor <see cref="Report"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        protected Report(string connectionString)
        {
            Factory = DAOFactory.GetInstance(connectionString);
            GetAllData();
        }

        /// <summary>
        /// Factory to create Data Access Object.
        /// </summary>
        public DAOFactory Factory { get; set; }
        /// <summary>
        /// Data from database table: Education forms
        /// </summary>
        public IEnumerable<EducationForm> EducationForms { get; set; }
        /// <summary>
        /// Data from database table: Genders
        /// </summary>
        public IEnumerable<Gender> Genders { get; set; }
        /// <summary>
        /// Data from database table: Groups
        /// </summary>
        public IEnumerable<Group> Groups { get; set; }
        /// <summary>
        /// Data from database table: Results
        /// </summary>
        public IEnumerable<Result> Results { get; set; }
        /// <summary>
        /// Data from database table: Schedules
        /// </summary>
        public IEnumerable<Schedule> Schedules { get; set; }
        /// <summary>
        /// Data from database table: Sessions
        /// </summary>
        public IEnumerable<Session> Sessions { get; set; }
        /// <summary>
        /// Data from database table: SessionPeriods
        /// </summary>
        public IEnumerable<SessionPeriod> SessionPeriods { get; set; }
        /// <summary>
        /// Data from database table: Students
        /// </summary>
        public IEnumerable<Student> Students { get; set; }
        /// <summary>
        /// Data from database table: Subjects
        /// </summary>
        public IEnumerable<Subject> Subjects { get; set; }
        /// <summary>
        /// Data from database table: TestForms
        /// </summary>
        public IEnumerable<TestForm> TestForms { get; set; }

        /// <summary>
        /// Get all data from database.
        /// </summary>
        void GetAllData()
        {
            EducationForms = Factory.GetEducationForm().ReadAllAsync().Result;
            Genders = Factory.GetGender().ReadAllAsync().Result;
            Sessions = Factory.GetSession().ReadAllAsync().Result;
            SessionPeriods = Factory.GetSessionPeriod().ReadAllAsync().Result;
            Results = Factory.GetResult().ReadAllAsync().Result;
            Schedules = Factory.GetSchedule().ReadAllAsync().Result;
            Groups = Factory.GetGroup().ReadAllAsync().Result;
            TestForms = Factory.GetTestForm().ReadAllAsync().Result;
            Students = Factory.GetStudent().ReadAllAsync().Result;
            Subjects = Factory.GetSubject().ReadAllAsync().Result;
        }
    }
}
