using System.Collections.Generic;

namespace BusinessLogicLayer.PointsByGroup
{
    /// <summary>
    /// Class containing the name of the session and a list of groups with a minimum score, a maximum score, and an average score.
    /// </summary>
    public class PointsByGroupTable
    {

        /// <summary>
        /// Class constructor <see cref="PointsByGroupTable"/>
        /// </summary>
        /// <param name="pointsByGroups"></param>
        /// <param name="sessionPeriod"></param>
        public PointsByGroupTable(IEnumerable<PointsByGroupUnit> pointsByGroups, string sessionPeriod)
        {
            this.pointsByGroups = pointsByGroups;
            SessionPeriod = sessionPeriod;
        }
        /// <summary>
        /// Session period
        /// </summary>
        public string SessionPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<PointsByGroupUnit> pointsByGroups;

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is PointsByGroupTable table &&
                   EqualityComparer<IEnumerable<PointsByGroupUnit>>.Default.Equals(pointsByGroups, table.pointsByGroups) &&
                   SessionPeriod == table.SessionPeriod;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            int hashCode = 1428001077;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SessionPeriod);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<PointsByGroupUnit>>.Default.GetHashCode(pointsByGroups);
            return hashCode;
        }
    }
}
