using DataAccessLayer.DataAccessObject;
using DataAccessLayer.ObjectRelationalMapping;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnitTestProject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    /// <summary>
    /// Checking write, read, update operations for each database table.
    /// </summary>
    [TestClass]
    public class CRUDTests : ConnectionInfo
    {
        /// <summary>
        /// Create <see cref="DAOFactory"/> object
        /// </summary>
        DAOFactory Factory;
        /// <summary>
        /// Data from database table: Genders
        /// </summary>
        IEnumerable<Gender> genders;
        /// <summary>
        /// Data from database table: SessionPeriod
        /// </summary>
        IEnumerable<SessionPeriod> periods;
        /// <summary>
        /// Data from database table: Session
        /// </summary>
        IEnumerable<Session> sessions;
        /// <summary>
        /// Data from database table: Subject
        /// </summary>
        IEnumerable<Subject> subject;
        /// <summary>
        /// Data from database table: Group
        /// </summary>
        IEnumerable<Group> groups;
        /// <summary>
        /// Data from database table: Specialty
        /// </summary>
        IEnumerable<Specialty> specialties;
        /// <summary>
        /// Data from database table: Examiner
        /// </summary>
        IEnumerable<Examiner> examiners;
        /// <summary>
        /// Data from database table: EducationForm
        /// </summary>
        IEnumerable<EducationForm> education_forms;
        /// <summary>
        /// Data from database table: TestForm
        /// </summary>
        IEnumerable<TestForm> test_forms;
        /// <summary>
        /// Data from database table: Students
        /// </summary>
        IEnumerable<Student> students;
        /// <summary>
        /// Data from database table: Schedules
        /// </summary>
        IEnumerable<Schedule> schedules;

        /// <summary>
        /// Get database tables.
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            Factory = DAOFactory.GetInstance(ConnectionString);
            genders = Factory.GetGender().ReadAllAsync().Result;
            periods = Factory.GetSessionPeriod().ReadAllAsync().Result;
            sessions = Factory.GetSession().ReadAllAsync().Result;
            subject = Factory.GetSubject().ReadAllAsync().Result;
            examiners = Factory.GetExaminer().ReadAllAsync().Result;
            specialties = Factory.GetSpecialty().ReadAllAsync().Result;
            groups = Factory.GetGroup().ReadAllAsync().Result;
            education_forms = Factory.GetEducationForm().ReadAllAsync().Result;
            test_forms = Factory.GetTestForm().ReadAllAsync().Result;
            students = Factory.GetStudent().ReadAllAsync().Result;
            schedules = Factory.GetSchedule().ReadAllAsync().Result;
        }

        [TestMethod]
        [DataRow("Man", "Woman")]
        public void GenderTests(string name, string name_update)
        {
            //Create.
            Assert.IsTrue(Factory.GetGender().InsertAsync(new Gender(name)).Result);

            //Read All
            IEnumerable<Gender> gender_list = Factory.GetGender().ReadAllAsync().Result;
            Assert.IsNotNull(gender_list);

            //Update.
            Assert.IsTrue(Factory.GetGender().UpdateAsync(new Gender(gender_list.Last().Id, name_update)).Result);

            //Is exist
            Assert.IsNotNull(Factory.GetGender().IsExistAsync(new Gender(gender_list.Last().Id, name_update)).Result);

            //Delete.
            Assert.IsTrue(Factory.GetGender().DeleteAsync(gender_list.Last().Id).Result);
        }

        [TestMethod]
        [DataRow(10, 7)]
        public void ResultTests(int actual_mark, int update_mark)
        {
            //Create.
            Assert.IsTrue(Factory.GetResult().InsertAsync(new Result(sessions.Last().Id, subject.Last().Id, students.Last().Id, actual_mark)).Result);

            //Read All
            IEnumerable<Result> result_list = Factory.GetResult().ReadAllAsync().Result;
            Assert.IsNotNull(result_list);

            //Update.
            Assert.IsTrue(Factory.GetResult().UpdateAsync(new Result(result_list.Last().Id, sessions.Last().Id, subject.Last().Id, students.Last().Id, update_mark)).Result);

            //Is exist
            Assert.IsNotNull(Factory.GetResult().IsExistAsync(new Result(result_list.Last().Id, sessions.Last().Id, subject.Last().Id, students.Last().Id, update_mark)).Result);

            //Delete.
            Assert.IsTrue(Factory.GetResult().DeleteAsync(result_list.Last().Id).Result);
        }
        [TestMethod]
        [DataRow(2020, 4, 1)]
        public void SchedulesTests(int year, int month, int day)
        {
            DateTime date = new DateTime(year: year, month: month, day: day);
            DateTime new_date = new DateTime(year: year + 1, month: month, day: day);
            //Create.
            Assert.IsTrue(Factory.GetSchedule().InsertAsync(new Schedule(date, subject.Last().Id, sessions.Last().Id, groups.Last().Id, test_forms.Last().Id, examiners.Last().Id)).Result);

            //Read All
            IEnumerable<Schedule> list = Factory.GetSchedule().ReadAllAsync().Result;
            Assert.IsNotNull(list);

            //Update.
            Assert.IsTrue(Factory.GetSchedule().UpdateAsync(new Schedule(list.Last().Id, new_date, subject.Last().Id, sessions.Last().Id, groups.Last().Id, education_forms.Last().Id, examiners.Last().Id)).Result);

            //Is exist
            Assert.IsNotNull(Factory.GetSchedule().IsExistAsync(new Schedule(list.Last().Id, new_date, subject.Last().Id, sessions.Last().Id, groups.Last().Id, education_forms.Last().Id, examiners.Last().Id)).Result);

            //Delete.
            Assert.IsTrue(Factory.GetSchedule().DeleteAsync(list.Last().Id).Result);
        }
        [TestMethod]
        [DataRow(2020, 4, 1, 2020, 4, 28)]
        public void SessionsTests(int year_from, int month_from, int day_from, int year_to, int month_to, int day_to)
        {
            DateTime dateFrom = new DateTime(year: year_from, month: month_from, day: day_from);
            DateTime dateTo = new DateTime(year: year_to, month: month_to, day: day_to);
            //Create.
            Assert.IsTrue(Factory.GetSession().InsertAsync(new Session(periods.Last().Id, dateTo, dateFrom)).Result);

            //Read All
            IEnumerable<Session> session_list = Factory.GetSession().ReadAllAsync().Result;
            Assert.IsNotNull(session_list);

            //Update (Rotate Date).
            Assert.IsTrue(Factory.GetSession().UpdateAsync(new Session(session_list.Last().Id, periods.Last().Id, dateFrom, dateTo)).Result);

            //Delete.
            Assert.IsTrue(Factory.GetSession().DeleteAsync(session_list.Last().Id).Result);
        }


        [TestMethod]
        [DataRow("NewGroup")]
        public void GroupTests(string name)
        {
            //Create.
            Assert.IsTrue(Factory.GetGroup().InsertAsync(new Group(name, specialties.Last().Id)).Result);

            //Read All
            IEnumerable<Group> group_list = Factory.GetGroup().ReadAllAsync().Result;
            Assert.IsNotNull(group_list);

            //Update.
            Assert.IsTrue(Factory.GetGroup().UpdateAsync(new Group(group_list.Last().Id, name + "Update", specialties.Last().Id)).Result);

            //Delete.
            Assert.IsTrue(Factory.GetGroup().DeleteAsync(group_list.Last().Id).Result);
        }
        [TestMethod]
        [DataRow(2020, 4, 1, "Ivan", "Ivanov", "Victorovich")]
        public void StudentsTests(int year, int month, int day, string name, string surname, string midlename)
        {
            DateTime date = new DateTime(year: year, month: month, day: day);

            //Create.
            Assert.IsTrue(Factory.GetStudent().InsertAsync(new Student(surname, name, midlename, genders.Last().Id, date, groups.Last().Id, education_forms.Last().Id)).Result);

            //Read All
            IEnumerable<Student> student_list = Factory.GetStudent().ReadAllAsync().Result;
            Assert.IsNotNull(student_list);

            //Update (Rotate (name-surname))
            Assert.IsTrue(Factory.GetStudent().UpdateAsync(new Student(student_list.Last().Id, name, surname, midlename, genders.Last().Id, date, groups.Last().Id, education_forms.Last().Id)).Result);

            //Delete.
            Assert.IsTrue(Factory.GetStudent().DeleteAsync(student_list.Last().Id).Result);

        }
        [TestMethod]
        [DataRow("NewSubjects")]
        public void SubjectsTests(string name)
        {
            //Create.
            Assert.IsTrue(Factory.GetSubject().InsertAsync(new Subject(name)).Result);

            //Read All
            IEnumerable<Subject> subjects_list = Factory.GetSubject().ReadAllAsync().Result;
            Assert.IsNotNull(subjects_list);

            //Update.
            Assert.IsTrue(Factory.GetSubject().UpdateAsync(new Subject(subjects_list.Last().Id, name + "Update")).Result);

            //Delete.
            Assert.IsTrue(Factory.GetSubject().DeleteAsync(subjects_list.Last().Id).Result);

        }
        [TestMethod]
        [DataRow("NewTestForm", "UpdateNewTestForm")]
        public void TestFormsTests(string name, string name_update)
        {
            //Create.
            Assert.IsTrue(Factory.GetTestForm().InsertAsync(new TestForm(name)).Result);

            //Read All
            IEnumerable<TestForm> testForm_list = Factory.GetTestForm().ReadAllAsync().Result;
            Assert.IsNotNull(testForm_list);

            //Update.
            Assert.IsTrue(Factory.GetTestForm().UpdateAsync(new TestForm(testForm_list.Last().Id, name_update)).Result);

            //Delete.
            Assert.IsTrue(Factory.GetTestForm().DeleteAsync(testForm_list.Last().Id).Result);

        }
        [TestMethod]
        [DataRow("NewEducationForm", "UpdateNewEducationForm")]
        public void EducationFormsTests(string name, string name_update)
        {
            //Create.
            Assert.IsTrue(Factory.GetEducationForm().InsertAsync(new EducationForm(name)).Result);

            //Read All
            IEnumerable<EducationForm> forms_list = Factory.GetEducationForm().ReadAllAsync().Result;
            Assert.IsNotNull(forms_list);

            //Update.
            Assert.IsTrue(Factory.GetEducationForm().UpdateAsync(new EducationForm(forms_list.Last().Id, name_update)).Result);

            //Delete.
            Assert.IsTrue(Factory.GetEducationForm().DeleteAsync(forms_list.Last().Id).Result);

        }
        [TestMethod]
        [DataRow("NewSessionPeriod", "UpdateNewSessionPeriod")]
        public void SessionPeriodsTests(string name, string name_update)
        {
            //Create.
            Assert.IsTrue(Factory.GetSessionPeriod().InsertAsync(new SessionPeriod(name)).Result);

            //Read All
            IEnumerable<SessionPeriod> period_list = Factory.GetSessionPeriod().ReadAllAsync().Result;
            Assert.IsNotNull(period_list);

            //Update.
            Assert.IsTrue(Factory.GetSessionPeriod().UpdateAsync(new SessionPeriod(period_list.Last().Id, name_update)).Result);

            //Delete.
            Assert.IsTrue(Factory.GetSessionPeriod().DeleteAsync(period_list.Last().Id).Result);
        }
    }
}
