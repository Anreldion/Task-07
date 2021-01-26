using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Task_07_Reports.AverageBallforExaminers
{
    /// <summary>
    /// Class allowing to get information about the average score by each examiner in one session.
    /// </summary>
    public class AverageBallforExaminersReport : Report
    {
        /// <summary>
        /// Class constructor <see cref="AverageBallforExaminersReport"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public AverageBallforExaminersReport(string connectionString) : base(connectionString)
        {
        }
        /// <summary>
        /// Get information report about the average score by each examiner in one session.
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <returns></returns>
        public AverageBallforExaminersTable GetReport(int sessionId)
        {
            return new AverageBallforExaminersTable(GetTableRows(sessionId), GetSessionPeriodName(sessionId));
        }
        /// <summary>
        /// Get list with <see cref="AverageBallforExaminersUnit"/>
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <returns>List with <see cref="AverageBallforExaminersUnit"/></returns>
        private IEnumerable<AverageBallforExaminersUnit> GetTableRows(int sessionId)
        {
            var searchresult = from examiner in Examiners
                               join schedules in Schedules on examiner.Id equals schedules.ExaminerID
                               join results in Results on schedules.SubjectId equals results.SubjectId
                               where results.SessionId == sessionId && results.SubjectId == schedules.SubjectId
                               select new
                               {
                                   Mark = results.Mark,
                                   examinerId = examiner.Id
                               };

            var averengeList = from s in searchresult
                               group s by s.examinerId into averengeByExaminer
                               select new
                               {
                                   ExaminerId = averengeByExaminer.Key,
                                   AverengeScore = averengeByExaminer.Average(a => a.Mark)
                               };

            return averengeList.Select(s => new AverageBallforExaminersUnit(GetExaminerName(s.ExaminerId), s.AverengeScore));
        }
        /// <summary>
        /// Get information report about the average score by each examiner in one session.
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="orderBy">Order by func</param>
        /// <returns><see cref="AverageBallforExaminersTable"/></returns>
        public AverageBallforExaminersTable GetReport(int sessionId, Func<AverageBallforExaminersUnit, object> orderBy)
        {
            AverageBallforExaminersTable table = GetReport(sessionId);
            table.table_rows = table.table_rows.OrderBy(orderBy);
            return table;
        }

        /// <summary>
        /// Get session period name.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <returns>Session period name</returns>
        string GetSessionPeriodName(int sessionId)
        {
            var name = from sessions in Sessions
                       join period in SessionPeriods on sessions.SessionPeriodId equals period.Id
                       where sessionId == sessions.Id
                       select new
                       {
                           Name = $"{period.Name} ({sessions.DateFrom:dd.MM.yy}-{sessions.DateTo:dd.MM.yy})"
                       };

            return name.Last().Name;
        }
        /// <summary>
        /// Get the examiner full name.
        /// </summary>
        /// <param name="examinerID">Examiner ID</param>
        /// <returns>examiner full name</returns>
        string GetExaminerName(int examinerID) 
        {
            var name = Examiners.Where(s => s.Id == examinerID).Select(s => $"{s.Surname} {s.Name} {s.MiddleName}");
            return name.Last();
        }
    }
}
