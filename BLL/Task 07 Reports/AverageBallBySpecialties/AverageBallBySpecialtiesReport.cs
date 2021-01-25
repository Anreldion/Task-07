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
    /// Класс для получения информации в рамках одной сессии о среднем бале по каждой специальности
    /// </summary>
    public class AverageBallBySpecialtiesReport : Report
    {
        /// <summary>
        /// Class constructor <see cref="AverageBallBySpecialtiesReport"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public AverageBallBySpecialtiesReport(string connectionString) : base(connectionString)
        {
        }
        /// <summary>
        /// Получить отчёт с информацией в рамках одной сессии о среднем бале по каждой специальности
        /// </summary>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        public AverageBallBySpecialtiesTable GetReport(int sessionId)
        {
            return new AverageBallBySpecialtiesTable(GetRow(sessionId), GetSessionPeriodName(sessionId));
        }
        /// <summary>
        /// Get list with <see cref="AverageBallBySpecialtiesUnit"/>
        /// </summary>
        /// <param name="sessionId"></param>
        /// <returns>list with <see cref="AverageBallBySpecialtiesUnit"/></returns>
        private IEnumerable<AverageBallBySpecialtiesUnit> GetRow(int sessionId)
        {
            var data = from specialties in Specialties
                       join groups in Groups on specialties.Id equals groups.SpecialtiesID
                       join students in Students on groups.Id equals students.GroupId
                       join results in Results on students.Id equals results.StudentId
                       where results.SessionId == sessionId
                       select new
                       {
                           Mark = results.Mark,
                           specialty = groups.SpecialtiesID
                       };

            var averengeList = from s in data
                               group s by s.specialty into averengeBySpecialty
                               select new 
                               {
                                   specialtyId = averengeBySpecialty.Key,
                                   AverengeScore = averengeBySpecialty.Average(a => a.Mark)
                               };

            return averengeList.Select(s => new AverageBallBySpecialtiesUnit(GetSpecialtyName(s.specialtyId), s.AverengeScore));
        }
        /// <summary>
        /// Получить отчёт с информацией в рамках одной сессии о среднем бале по каждой специальности
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="orderBy">Order by func</param>
        /// <returns></returns>
        public AverageBallBySpecialtiesTable GetReport(int sessionId, Func<AverageBallBySpecialtiesUnit, object> orderBy)
        {
            AverageBallBySpecialtiesTable table = GetReport(sessionId);
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
        /// <summary>
        /// Get specialty name.
        /// </summary>
        /// <param name="specialtyId">Specialty ID</param>
        /// <returns>Specialty name</returns>
        string GetSpecialtyName(int specialtyId) => Specialties.FirstOrDefault(s => s.Id == specialtyId)?.Name;
    }
}
