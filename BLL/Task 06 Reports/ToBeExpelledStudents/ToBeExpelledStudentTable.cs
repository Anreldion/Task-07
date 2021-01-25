using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.DeductibleStudent
{
    /// <summary>
    /// Class containing the name of the group and the list of students to be expelled.
    /// </summary>
    public class ToBeExpelledStudentTable
    {
        /// <summary>
        /// Class constructor <see cref="ToBeExpelledStudentTable"/>
        /// </summary>
        /// <param name="deductibleStudents">The list of students to be expelled</param>
        /// <param name="group">Group name</param>
        public ToBeExpelledStudentTable(IEnumerable<ToBeExpelledStudentUnit> deductibleStudents, string group)
        {
            this.deductibleStudents = deductibleStudents;
            GroupName = group;
        }
        /// <summary>
        /// The list of students to be expelled
        /// </summary>
        public IEnumerable<ToBeExpelledStudentUnit> deductibleStudents;
        /// <summary>
        /// Group name
        /// </summary>
        public string GroupName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ToBeExpelledStudentTable table &&
                   EqualityComparer<IEnumerable<ToBeExpelledStudentUnit>>.Default.Equals(deductibleStudents, table.deductibleStudents) &&
                   GroupName == table.GroupName;
        }

        public override int GetHashCode()
        {
            int hashCode = 245339689;
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<ToBeExpelledStudentUnit>>.Default.GetHashCode(deductibleStudents);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GroupName);
            return hashCode;
        }
    }
}
