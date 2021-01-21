using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.SessionResult
{
    /// <summary>
    /// The class allows you to create up the session for each group in a table.
    /// </summary>
    public class SessionResultReport : Report
    {
        /// <summary>
        /// Class constructor <see cref="SessionResultReport"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public SessionResultReport(string connectionString) : base(connectionString)
        {
        }
        /// <summary>
        /// Get the session summary for each group in the form of a table.
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <returns>List with <see cref="SessionResultTable"/></returns>
        public IEnumerable<SessionResultTable> GetReport(int sessionId)
        {
            return GetGroupId(sessionId).Select(groupId => new SessionResultTable(GetRowSessionResult(sessionId, groupId), GetGroupName(groupId))).ToList();
        }
        /// <summary>
        /// Get the session summary for each group in the form of a table.
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="orderBy">Sorting elements of a collection</param>
        /// <returns></returns>
        public IEnumerable<SessionResultTable> GetReport(int sessionId, Func<SessionResultUnit, object> orderBy)
        {
            IEnumerable<SessionResultTable> list = GetReport(sessionId);
            foreach (var item in list)
            {
                item.sessionResults = item.sessionResults.OrderBy(orderBy);
            }
            return list;
        }
        /// <summary>
        /// Get a list with session results.
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="groupId">Group ID</param>
        /// <returns>List <see cref="SessionResultUnit"/></returns>
        IEnumerable<SessionResultUnit> GetRowSessionResult(int sessionId, int groupId) //+
        {
            return from students in Students //
                   join results in Results on students.Id equals results.StudentId
                   join subjects in Subjects on results.SubjectId equals subjects.Id
                   join schedules in Schedules on students.GroupId equals schedules.GroupId
                   join testForms in TestForms on schedules.TestFormId equals testForms.Id
                   join groups in Groups on students.GroupId equals groups.Id
                   where schedules.SessionId == sessionId && students.GroupId == groupId && schedules.SubjectId == results.SubjectId
                   select new SessionResultUnit(students.Name, students.Surname, students.MiddleName, subjects.Name, results.Mark, schedules.Date, testForms.Name);
        }
        /// <summary>
        /// Get an array with group IDs for the specified session
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Group IDs array</returns>
        int[] GetGroupId(int sessionId) => Schedules.Where(s => s.SessionId == sessionId).Select(s => s.GroupId).Distinct().ToArray();
        /// <summary>
        /// Get group name by ID
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns>Group name, otherwise null</returns>
        string GetGroupName(int groupId) => Groups.FirstOrDefault(g => g.Id == groupId)?.Name;

    }
}
