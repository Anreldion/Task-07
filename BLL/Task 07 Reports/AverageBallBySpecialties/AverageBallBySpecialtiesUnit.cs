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
    public class AverageBallBySpecialtiesUnit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="specialty"></param>
        /// <param name="averageBall"></param>
        public AverageBallBySpecialtiesUnit(string specialty, double averageBall)
        {
            Specialty = specialty;
            AverageBall = averageBall;
        }

        /// <summary>
        /// Specialty name
        /// </summary>
        public string Specialty { get; set; }
        /// <summary>
        /// Average ball
        /// </summary>
        public double AverageBall { get; set; }

        public override bool Equals(object obj)
        {
            return obj is AverageBallBySpecialtiesUnit unit &&
                   Specialty == unit.Specialty &&
                   AverageBall == unit.AverageBall;
        }

        public override int GetHashCode()
        {
            int hashCode = -2145933388;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Specialty);
            hashCode = hashCode * -1521134295 + EqualityComparer<double>.Default.GetHashCode(AverageBall);
            return hashCode;
        }
    }
}
