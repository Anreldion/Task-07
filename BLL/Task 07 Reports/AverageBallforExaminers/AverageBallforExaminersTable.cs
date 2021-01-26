using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Task_07_Reports.AverageBallforExaminers
{
    /// <summary>
    /// Class containing the name of the session and a list of average score for examiners.
    /// </summary>
    public class AverageBallforExaminersTable
    {
        /// <summary>
        /// List with <see cref="AverageBallforExaminersUnit"/>
        /// </summary>
        public IEnumerable<AverageBallforExaminersUnit> table_rows;
        /// <summary>
        /// Class constructor <see cref="AverageBallforExaminersTable"/>
        /// </summary>
        /// <param name="table_rows">List with <see cref="AverageBallforExaminersUnit"/></param>
        /// <param name="sessionName">Session name</param>
        public AverageBallforExaminersTable(IEnumerable<AverageBallforExaminersUnit> table_rows, string sessionName)
        {
            this.table_rows = table_rows;
            SessionName = sessionName;
        }

        /// <summary>
        /// Session name.
        /// </summary>
        public string SessionName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is AverageBallforExaminersTable table &&
                   EqualityComparer<IEnumerable<AverageBallforExaminersUnit>>.Default.Equals(table_rows, table.table_rows) &&
                   SessionName == table.SessionName;
        }

        public override int GetHashCode()
        {
            int hashCode = -1210903087;
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<AverageBallforExaminersUnit>>.Default.GetHashCode(table_rows);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SessionName);
            return hashCode;
        }
    }
}
