using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.PointsByGroup
{
    /// <summary>
    /// The class contains information about the average / minimum / maximum score for the group
    /// </summary>
    public class PointsByGroupUnit
    {
        /// <summary>
        /// Class constructor <see cref="PointsByGroupUnit"/>
        /// </summary>
        /// <param name="groupName">Group name</param>
        /// <param name="minimumScore">Minimum score</param>
        /// <param name="averageScore">Average score</param>
        /// <param name="maximumScore">Maximum score</param>
        /// <param name="sessionId"></param>
        public PointsByGroupUnit(string groupName, double minimumScore, double averageScore, double maximumScore, int sessionId)
        {
            GroupName = groupName;
            MinimumScore = minimumScore;
            AverageScore = averageScore;
            MaximumScore = maximumScore;
            SessionId = sessionId;
        }

        /// <summary>
        /// Group name 
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// Minimum score
        /// </summary>
        public double MinimumScore { get; set; }
        /// <summary>
        /// Average score
        /// </summary>
        public double AverageScore { get; set; }
        /// <summary>
        /// Maximum score
        /// </summary>
        public double MaximumScore { get; set; }
        /// <summary>
        /// Session ID
        /// </summary>
        public int SessionId { get; set; }
        
        public override bool Equals(object obj)
        {
            return obj is PointsByGroupUnit table &&
                   GroupName == table.GroupName &&
                   MinimumScore == table.MinimumScore &&
                   AverageScore == table.AverageScore &&
                   SessionId == table.SessionId &&
                   MaximumScore == table.MaximumScore;
        }

        public override int GetHashCode()
        {
            int hashCode = 1513404607;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GroupName);
            hashCode = hashCode * -1521134295 + MinimumScore.GetHashCode();
            hashCode = hashCode * -1521134295 + AverageScore.GetHashCode();
            hashCode = hashCode * -1521134295 + MaximumScore.GetHashCode();
            hashCode = hashCode * -1521134295 + SessionId.GetHashCode();
            return hashCode;
        }
    }
}
