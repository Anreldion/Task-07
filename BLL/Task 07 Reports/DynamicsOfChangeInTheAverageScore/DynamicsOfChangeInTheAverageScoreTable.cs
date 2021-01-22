using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Task_07_Reports.DynamicsOfChangeInTheAverageScore
{
    public class DynamicsOfChangeInTheAverageScoreTable
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<DynamicsOfChangeInTheAverageScoreUnit> table_rows;
        /// <summary>
        /// Class constructor <see cref="DynamicsOfChangeInTheAverageScoreUnit"/>
        /// </summary>
        /// <param name="table_rows"></param>
        /// <param name="subjectName"></param>
        public DynamicsOfChangeInTheAverageScoreTable(IEnumerable<DynamicsOfChangeInTheAverageScoreUnit> table_rows, string subjectName)
        {
            this.table_rows = table_rows;
            SubjectName = subjectName;
        }

        /// <summary>
        /// 
        /// </summary>
        public string SubjectName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DynamicsOfChangeInTheAverageScoreTable table &&
                   EqualityComparer<IEnumerable<DynamicsOfChangeInTheAverageScoreUnit>>.Default.Equals(table_rows, table.table_rows) &&
                   SubjectName == table.SubjectName;
        }

        public override int GetHashCode()
        {
            int hashCode = -1461274839;
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<DynamicsOfChangeInTheAverageScoreUnit>>.Default.GetHashCode(table_rows);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SubjectName);
            return hashCode;
        }
    }
}
