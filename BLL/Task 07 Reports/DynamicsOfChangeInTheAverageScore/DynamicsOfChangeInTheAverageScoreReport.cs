using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Task_07_Reports.DynamicsOfChangeInTheAverageScore
{
    public class DynamicsOfChangeInTheAverageScoreReport : Report
    {
        public DynamicsOfChangeInTheAverageScoreReport(string connectionString) : base(connectionString)
        {
        }
        public IEnumerable<DynamicsOfChangeInTheAverageScoreTable> GetReport()
        {
            return GetSubjectsId().Select(subjectId => new DynamicsOfChangeInTheAverageScoreTable(GetRow(subjectId), GetSubjectName(subjectId))).ToList();
        }

        private IEnumerable<DynamicsOfChangeInTheAverageScoreUnit> GetRow(int subjectId)
        {
            throw new NotImplementedException();
        }

        // SubjectName = subjectName;

        // SessionPeriod = sessionPeriod;
        // AverageBall = averageBall;
        public IEnumerable<DynamicsOfChangeInTheAverageScoreTable> GetReport(Func<DynamicsOfChangeInTheAverageScoreUnit, object> orderBy)
        {
            IEnumerable<DynamicsOfChangeInTheAverageScoreTable> list = GetReport();
            foreach (var item in list)
            {
                item.table_rows = item.table_rows.OrderBy(orderBy);
            }
            return list;
        }

        int[] GetSubjectsId() => Subjects.Select(s => s.Id).ToArray();
        string GetSubjectName(int subjectId) => Subjects.FirstOrDefault(s => s.Id == subjectId)?.Name;
    }
}
