using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    /// <summary>
    /// Class describes Student row
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Student()
        {
        }
        /// <summary>
        /// Class constructor <see cref="Student"/>
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="middleName">MiddleName</param>
        /// <param name="genderId">Gender ID</param>
        /// <param name="dateofBirth">Date of birth</param>
        /// <param name="groupId">Group ID</param>
        /// <param name="educationFormId">Education form ID</param>
        public Student(string name, string surname, string middleName, int genderId, DateTime dateofBirth, int groupId, int educationFormId)
        {
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            GenderId = genderId;
            DateofBirth = dateofBirth;
            GroupId = groupId;
            EducationFormId = educationFormId;
        }
        /// <summary>
        /// Class constructor <see cref="Student"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="middleName">MiddleName</param>
        /// <param name="genderId">Gender ID</param>
        /// <param name="dateofBirth">Date of birth</param>
        /// <param name="groupId">Group ID</param>
        /// <param name="educationFormId">Education form ID</param>
        public Student(int id, string name, string surname, string middleName, int genderId, DateTime dateofBirth, int groupId, int educationFormId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            GenderId = genderId;
            DateofBirth = dateofBirth;
            GroupId = groupId;
            EducationFormId = educationFormId;
        }


        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// MiddleName
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Gender ID
        /// </summary>
        public int GenderId { get; set; }
        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime DateofBirth { get; set; }
        /// <summary>
        /// Group ID
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Education form ID
        /// </summary>
        public int EducationFormId { get; set; }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   GenderId == student.GenderId &&
                   DateofBirth == student.DateofBirth &&
                   GroupId == student.GroupId &&
                   EducationFormId == student.EducationFormId;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Surname, GenderId, DateofBirth, GroupId, EducationFormId);
        }
        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            return $"Id:{Id}, {Name} {Surname} {MiddleName}";
        }
    }
}
