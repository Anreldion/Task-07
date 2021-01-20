using System;

namespace BusinessLogicLayer.DeductibleStudent
{
    /// <summary>
    /// Class containing information about the student to be expelled.
    /// </summary>
    public class DeductibleStudentUnit
    {
        /// <summary>
        /// Class constructor <see cref="DeductibleStudentUnit"/>
        /// </summary>
        /// <param name="name">Student name</param>
        /// <param name="surname">Student surname</param>
        /// <param name="middleName">Student middleName</param>
        /// <param name="educationForm">Education form</param>
        /// <param name="groupName">Group name</param>
        public DeductibleStudentUnit(string name, string surname, string middleName, string educationForm, string groupName)
        {
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            EducationForm = educationForm;
            GroupName = groupName;
        }
        /// <summary>
        /// Student name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Student surname
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Student middleName
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Education form
        /// </summary>
        public string EducationForm { get; set; }
        /// <summary>
        /// Group name
        /// </summary>
        public string GroupName { get; set; }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is DeductibleStudentUnit student &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   MiddleName == student.MiddleName &&
                   GroupName == student.GroupName &&
                   EducationForm == student.EducationForm;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname, MiddleName, EducationForm, GroupName);
        }
        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            return $"{Surname} {Name} {MiddleName}";
        }
    }
}
