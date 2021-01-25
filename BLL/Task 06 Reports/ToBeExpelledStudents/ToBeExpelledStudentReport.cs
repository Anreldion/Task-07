using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.DeductibleStudent
{
    /// <summary>
    /// Class for formation of tables of students to be expelled, sorted by groups.
    /// </summary>
    public class ToBeExpelledStudentReport : Report
    {
        /// <summary>
        /// Class constructor <see cref="ToBeExpelledStudentReport"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public ToBeExpelledStudentReport(string connectionString) : base(connectionString)
        {
        }


        /// <summary>
        /// Get a list of tables by group containing full names of students to be expelled.
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="passing_score">Passing score</param>
        /// <returns>List with <see cref="ToBeExpelledStudentTable"/></returns>
        public IEnumerable<ToBeExpelledStudentTable> GetReport(int sessionId, int passing_score)
        {
            string[] GroupNames = GetGroupNames().Distinct().ToArray();
            List<ToBeExpelledStudentTable> list = new List<ToBeExpelledStudentTable>();
            foreach (var groupName in GroupNames)
            {
                list.Add(new ToBeExpelledStudentTable(GetStudents(sessionId, passing_score, groupName), groupName));
            }

            return list;
        }
        /// <summary>
        /// Get a list of tables by group containing full names of students to be expelled.
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="passing_score">Passing score</param>
        /// <param name="orderBy">Sorting elements of the collection</param>
        /// <returns>List with <see cref="ToBeExpelledStudentTable"/></returns>
        public IEnumerable<ToBeExpelledStudentTable> GetReport(int sessionId, int passing_score, Func<ToBeExpelledStudentUnit, object> orderBy)
        {
            IEnumerable<ToBeExpelledStudentTable> list = GetReport(sessionId, passing_score);
            foreach (var item in list)
            {
                item.deductibleStudents = item.deductibleStudents.OrderBy(orderBy);
            }
            return list;
        }
        /// <summary>
        /// Get information about the student to be expelled.
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="passing_score">Passing score</param>
        /// <param name="groupName">Group name</param>
        /// <returns>List with <see cref="ToBeExpelledStudentUnit"/></returns>
        private IEnumerable<ToBeExpelledStudentUnit> GetStudents(int sessionId, int passing_score, string groupName)
        {
            IEnumerable<(int, int, int)> StudentIdAndFormEducationIdAndGroupID = GetStudentIdAndFormEducationIdAndGroupID(sessionId, 6).Distinct();
            IEnumerable<ToBeExpelledStudentUnit> AllDeductibleStudents = from sfg in StudentIdAndFormEducationIdAndGroupID
                                                                       join students in Students on sfg.Item1 equals students.Id
                                                                       join groups in Groups on sfg.Item2 equals groups.Id
                                                                       join form in EducationForms on sfg.Item3 equals form.Id
                                                                       select (new ToBeExpelledStudentUnit(students.Name, students.Surname, students.MiddleName, form.Name, groups.Name));
            IEnumerable<ToBeExpelledStudentUnit> deductibleStudent = from ads in AllDeductibleStudents
                                                                   where (groupName == ads.GroupName)
                                                                   select ads;
            return deductibleStudent;
        }
        /// <summary>
        /// Get student IDs to be expelled.
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="passing_score">Passing score</param>
        /// <returns>IEnumerable<(int StudentId, int GroupId, int EducationFormId)></returns>
        private IEnumerable<(int, int, int)> GetStudentIdAndFormEducationIdAndGroupID(int sessionId, int passing_score)// => Results.Where(result => result.Mark < mark && result.SessionId == sessionId).Select(results, group => results.StudentId).Distinct();
        {
            return from result in Results
                   join studene in Students on result.StudentId equals studene.Id
                   join ed_form in EducationForms on studene.EducationFormId equals ed_form.Id
                   where result.Mark < passing_score && result.SessionId == sessionId
                   select (result.StudentId, studene.GroupId, ed_form.Id);
        }
        /// <summary>
        /// Get unique group names
        /// </summary>
        /// <returns>Array with group names</returns>
        public string[] GetGroupNames() => Groups.Select(g => g.Name).Distinct().ToArray();
    }
}
