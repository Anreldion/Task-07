using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Task_07_Reports.AverageBallBySpecialties
{
    /// <summary>
    /// 
    /// </summary>
    public class AverageBallBySpecialtiesTable
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AverageBallBySpecialtiesUnit> table_rows;
        /// <summary>
        /// Class constructor <see cref="AverageBallBySpecialtiesTable"/>
        /// </summary>
        /// <param name="table_rows"></param>
        /// <param name="sessionName"></param>
        public AverageBallBySpecialtiesTable(IEnumerable<AverageBallBySpecialtiesUnit> table_rows, string sessionName)
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
            return obj is AverageBallBySpecialtiesTable table &&
                   EqualityComparer<IEnumerable<AverageBallBySpecialtiesUnit>>.Default.Equals(table_rows, table.table_rows) &&
                   SessionName == table.SessionName;
        }

        public override int GetHashCode()
        {
            int hashCode = -2080304237;
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<AverageBallBySpecialtiesUnit>>.Default.GetHashCode(table_rows);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SessionName);
            return hashCode;
        }
    }
}
