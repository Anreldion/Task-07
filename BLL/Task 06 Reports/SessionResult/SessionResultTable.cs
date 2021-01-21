using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.SessionResult
{
    /// <summary>
    /// Group results table.
    /// </summary>
    public class SessionResultTable
    {
        /// <summary>
        /// Class constructor <see cref="SessionResultTable"/>
        /// </summary>
        /// <param name="sessionResults"></param>
        /// <param name="groupName">Group name</param>
        public SessionResultTable(IEnumerable<SessionResultUnit> sessionResults, string groupName)
        {
            this.sessionResults = sessionResults;
            GroupName = groupName;
        }
        /// <summary>
        /// Student execution result
        /// </summary>
        public IEnumerable<SessionResultUnit> sessionResults;
        /// <summary>
        /// Group name
        /// </summary>
        public string GroupName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is SessionResultTable table &&
                   EqualityComparer<IEnumerable<SessionResultUnit>>.Default.Equals(sessionResults, table.sessionResults) &&
                   GroupName == table.GroupName;
        }

        public override int GetHashCode()
        {
            int hashCode = 189740902;
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<SessionResultUnit>>.Default.GetHashCode(sessionResults);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GroupName);
            return hashCode;
        }
    }
}
