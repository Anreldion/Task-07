using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Task_07_Reports.AverageBallforExaminers
{
    public class AverageBallforExaminersReport : Report
    {
        public AverageBallforExaminersReport(string connectionString) : base(connectionString)
        {
        }
        public IEnumerable<AverageBallforExaminersTable> GetReport(int sessionId)
        {
            return GetSessionsId().Select(s => new AverageBallforExaminersTable(GetRow(), GetSessionPeriodName(sessionId))).ToList();
        }

        private IEnumerable<AverageBallforExaminersUnit> GetRow()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AverageBallforExaminersTable> GetReport(int sessionId, Func<AverageBallforExaminersUnit, object> orderBy)
        {
            IEnumerable<AverageBallforExaminersTable> list = GetReport(sessionId);
            foreach (var item in list)
            {
                item.table_rows = item.table_rows.OrderBy(orderBy);
            }
            return list;
        }

        int[] GetSessionsId() => Sessions.Select(s => s.Id).ToArray();
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
