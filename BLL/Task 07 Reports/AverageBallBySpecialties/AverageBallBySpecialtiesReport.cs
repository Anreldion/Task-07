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
            return GetSpecialtiesId().Select(specialty => new AverageBallBySpecialtiesTable(GetRow(sessionId), GetSessionPeriodName(sessionId))).ToList();
        }

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

        public IEnumerable<AverageBallBySpecialtiesTable> GetReport(int sessionId, Func<AverageBallBySpecialtiesUnit, object> orderBy)
        {
            IEnumerable<AverageBallBySpecialtiesTable> list = GetReport(sessionId);
            foreach (var item in list)
            {
                item.table_rows = item.table_rows.OrderBy(orderBy);
            }
            return list;
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

        int[] GetSpecialtiesId() => Specialties.Select(s => s.Id).ToArray();
        /// <summary>
        /// Get session period name.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <returns>Session period name</returns>
        string GetSpecialtyName(int specialtyId) => Specialties.FirstOrDefault(s => s.Id == specialtyId)?.Name;
    }
}
