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
        public AverageBallforExaminersUnit(string examiner, double averageBall)
        {
            Examiner = examiner;
            AverageBall = averageBall;
        }
        /// <summary>
        /// Subject name
        /// </summary>
        public string Examiner { get; set; }
        /// <summary>
        /// Average ball
        /// </summary>
        public double AverageBall { get; set; }

        public override bool Equals(object obj)
        {
            return obj is AverageBallforExaminersUnit unit &&
                   Examiner == unit.Examiner &&
                   AverageBall == unit.AverageBall;
        }

        public override int GetHashCode()
        {
            int hashCode = 329264596;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Examiner);
            hashCode = hashCode * -1521134295 + EqualityComparer<double>.Default.GetHashCode(AverageBall);
            return hashCode;
        }
    }
}
