using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.DeductibleStudent
{
    /// <summary>
    /// Class containing the name of the group and the list of students to be expelled.
    /// </summary>
    public class DeductibleStudentsTable
    {
        /// <summary>
        /// Class constructor <see cref="DeductibleStudentsTable"/>
        /// </summary>
        /// <param name="deductibleStudents">The list of students to be expelled</param>
        /// <param name="group">Group name</param>
        public DeductibleStudentsTable(IEnumerable<DeductibleStudentUnit> deductibleStudents, string group)
        {
            this.deductibleStudents = deductibleStudents;
            GroupName = group;
        }
        /// <summary>
        /// The list of students to be expelled
        /// </summary>
        public IEnumerable<DeductibleStudentUnit> deductibleStudents;
        /// <summary>
        /// Group name
        /// </summary>
        public string GroupName { get; set; }

        
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is DeductibleStudentsTable table &&
                   EqualityComparer<IEnumerable<DeductibleStudentUnit>>.Default.Equals(deductibleStudents, table.deductibleStudents) &&
                   GroupName == table.GroupName;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(deductibleStudents, GroupName);
        }
    }
}
