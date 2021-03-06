﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Task_07_Reports.DynamicsOfChangeInTheAverageScore
{
    /// <summary>
    /// Class containing information about the average score by session.
    /// </summary>
    public class DynamicsOfChangeInTheAverageScoreUnit
    {
        /// <summary>
        /// Class constructor <see cref="DynamicsOfChangeInTheAverageScoreUnit"/>
        /// </summary>
        /// <param name="sessionPeriod"></param>
        /// <param name="averageBall"></param>
        public DynamicsOfChangeInTheAverageScoreUnit(string sessionPeriod, double averageBall)
        {
            SessionPeriod = sessionPeriod;
            AverageBall = averageBall;
        }

        /// <summary>
        /// Session period
        /// </summary>
        public string SessionPeriod { get; set; }
        /// <summary>
        /// Average ball
        /// </summary>
        public double AverageBall { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DynamicsOfChangeInTheAverageScoreUnit unit &&
                   SessionPeriod == unit.SessionPeriod &&
                   AverageBall == unit.AverageBall;
        }

        public override int GetHashCode()
        {
            int hashCode = 1739092515;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SessionPeriod);
            hashCode = hashCode * -1521134295 + EqualityComparer<double>.Default.GetHashCode(AverageBall);
            return hashCode;
        }
    }
}
