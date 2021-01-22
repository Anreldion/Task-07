using System.Collections.Generic;

namespace BLL.Task_07_Reports.AverageBallforExaminers
{
    /// <summary>
    /// 
    /// </summary>
    public class AverageBallforExaminersUnit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subject">Subject name</param>
        /// <param name="averageBall">Average ball</param>
        public AverageBallforExaminersUnit(string subject, string averageBall)
        {
            Subject = subject;
            AverageBall = averageBall;
        }
        /// <summary>
        /// Subject name
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Average ball
        /// </summary>
        public string AverageBall { get; set; }

        public override bool Equals(object obj)
        {
            return obj is AverageBallforExaminersUnit unit &&
                   Subject == unit.Subject &&
                   AverageBall == unit.AverageBall;
        }

        public override int GetHashCode()
        {
            int hashCode = 329264596;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Subject);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AverageBall);
            return hashCode;
        }
    }
}
