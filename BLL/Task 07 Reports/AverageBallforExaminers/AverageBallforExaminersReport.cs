using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Task_07_Reports.AverageBallforExaminers
{
    /// <summary>
    /// Дополнить отчёты информацией в рамках одной сессии о среднем бале по каждому экзаменатору
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

        public AverageBallforExaminersTable GetReport(int sessionId)
        {
            return new AverageBallforExaminersTable(GetTableRows(sessionId), GetSessionPeriodName(sessionId));
        }

        private IEnumerable<AverageBallforExaminersUnit> GetTableRows(int sessionId)
        {
            var searchresult = from examiner in Examiners
                         join schedules in Schedules on examiner.Id equals schedules.ExaminerID
                         join results in Results on schedules.SubjectId equals results.SubjectId
                         where schedules.SubjectId == sessionId && results.SessionId == sessionId && results.SubjectId == schedules.SubjectId
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
            IEnumerable<(string, DateTime, DateTime)> name = from sessions in Sessions
                                                             join period in SessionPeriods on sessions.SessionPeriodId equals period.Id
                                                             where sessionId == sessions.Id
                                                             select (period.Name, sessions.DateFrom, sessions.DateTo);

            return $"{name.Last().Item1} ({name.Last().Item2:dd.MM.yy} - {name.Last().Item3:dd.MM.yy})";
        }

        string GetExaminerName(int examinerID) => Examiners.FirstOrDefault(s => s.Id == examinerID)?.Name;
    }
}
