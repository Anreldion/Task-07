using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Task_07_Reports.AverageBallforExaminers
{
    public class AverageBallforExaminersTable
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AverageBallforExaminersUnit> table_rows;
        /// <summary>
        /// Class constructor <see cref="AverageBallforExaminersTable"/>
        /// </summary>
        /// <param name="table_rows"></param>
        /// <param name="sessionName"></param>
        public AverageBallforExaminersTable(IEnumerable<AverageBallforExaminersUnit> table_rows, string sessionName)
        {
            this.table_rows = table_rows;
            SessionName = sessionName;
        }

        /// <summary>
        /// 
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
