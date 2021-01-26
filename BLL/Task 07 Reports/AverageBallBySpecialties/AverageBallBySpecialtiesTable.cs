using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Task_07_Reports.AverageBallBySpecialties
{
    /// <summary>
    /// Class containing the name of the session and a list of average score by specialties.
    /// </summary>
    public class AverageBallBySpecialtiesTable
    {
        /// <summary>
        /// List with <see cref="AverageBallBySpecialtiesUnit"/>
        /// </summary>
        public IEnumerable<AverageBallBySpecialtiesUnit> table_rows;
        /// <summary>
        /// Class constructor <see cref="AverageBallBySpecialtiesTable"/>
        /// </summary>
        /// <param name="table_rows">List with <see cref="AverageBallBySpecialtiesUnit"/></param>
        /// <param name="sessionName">Session name</param>
        public AverageBallBySpecialtiesTable(IEnumerable<AverageBallBySpecialtiesUnit> table_rows, string sessionName)
        {
            this.table_rows = table_rows;
            SessionName = sessionName;
        }
        /// <summary>
        /// Session name
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
