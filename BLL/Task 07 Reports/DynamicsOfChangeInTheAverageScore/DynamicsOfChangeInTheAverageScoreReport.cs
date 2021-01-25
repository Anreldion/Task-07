using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Task_07_Reports.DynamicsOfChangeInTheAverageScore
{
    /// <summary>
    /// В рамках всех сессий вывести в виде таблицы динамику изменения среднего бала по каждому предмету по годам
    /// </summary>
    public class DynamicsOfChangeInTheAverageScoreReport : Report
    {
        /// <summary>
        /// Class constructor <see cref="DynamicsOfChangeInTheAverageScoreReport"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DynamicsOfChangeInTheAverageScoreReport(string connectionString) : base(connectionString)
        {
        }
        public IEnumerable<DynamicsOfChangeInTheAverageScoreTable> GetReport()
        {
            return GetSubjectsId().Select(subjectId => new DynamicsOfChangeInTheAverageScoreTable(GetRow(subjectId), GetSubjectName(subjectId))).ToList();
        }
        /// <summary>
        /// Get list with <see cref="DynamicsOfChangeInTheAverageScoreUnit"/>
        /// </summary>
        /// <param name="subjectId">Subjects ID</param>
        /// <returns>list with <see cref="DynamicsOfChangeInTheAverageScoreUnit"/></returns>
        private IEnumerable<DynamicsOfChangeInTheAverageScoreUnit> GetRow(int subjectId)
        {
            IEnumerable<(int, int)> marksAndSessionId = from results in Results
            where results.SubjectId == subjectId
            select (results.Mark, results.SessionId);

            var averengeBySession =
                from mas in marksAndSessionId
                group mas by mas.Item2 into averengeByGroup
                select new
                {
                    SessionId = averengeByGroup.Key,
                    AverengeScore = averengeByGroup.Average(a => a.Item1)
                };

            return averengeBySession.Select(s => new DynamicsOfChangeInTheAverageScoreUnit(GetSessionPeriodName(s.SessionId), s.AverengeScore));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderBy">Sorting elements of the collection</param>
        /// <returns></returns>
        public IEnumerable<DynamicsOfChangeInTheAverageScoreTable> GetReport(Func<DynamicsOfChangeInTheAverageScoreUnit, object> orderBy)
        {
            IEnumerable<DynamicsOfChangeInTheAverageScoreTable> list = GetReport();
            foreach (var item in list)
            {
                item.table_rows = item.table_rows.OrderBy(orderBy);
            }
            return list;
        }
        /// <summary>
        /// Get subjects IDs
        /// </summary>
        /// <returns>Subjects IDs array</returns>
        int[] GetSubjectsId() => Subjects.Select(s => s.Id).ToArray();
        /// <summary>
        /// Get subject name
        /// </summary>
        /// <param name="subjectId">Subject ID</param>
        /// <returns>Subject name</returns>
        string GetSubjectName(int subjectId) => Subjects.FirstOrDefault(s => s.Id == subjectId)?.Name;
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
    }
}
