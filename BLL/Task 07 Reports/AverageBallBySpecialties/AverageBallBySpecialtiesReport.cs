using BusinessLogicLayer;
using BusinessLogicLayer.DeductibleStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Task_07_Reports.AverageBallBySpecialties
{
    /// <summary>
    /// Дополнить отчёты информацией в рамках одной сессии о среднем бале по каждой специальности
    /// </summary>
    public class AverageBallBySpecialtiesReport : Report
    {
        public AverageBallBySpecialtiesReport(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<AverageBallBySpecialtiesTable> GetReport(int sessionId)
        {
            return GetSessionsId().Select(s => new AverageBallBySpecialtiesTable(GetRow(), GetSessionPeriodName(sessionId))).ToList();
        }

        private IEnumerable<AverageBallBySpecialtiesUnit> GetRow()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AverageBallBySpecialtiesTable> GetReport(int sessionId, Func<AverageBallBySpecialtiesUnit, object> orderBy)
        {
            IEnumerable<AverageBallBySpecialtiesTable> list = GetReport(sessionId);
            foreach (var item in list)
            {
                item.table_rows = item.table_rows.OrderBy(orderBy);
            }
            return list;
        }
        //SessionName

        //Specialty 
        //AverageBall
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
