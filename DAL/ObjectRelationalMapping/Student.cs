using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes Student row
    /// </summary>
    [Table(Name = "Students")]
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
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Column(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// Surname
        /// </summary>
        [Column(Name = "Surname")]
        public string Surname { get; set; }
        /// <summary>
        /// MiddleName
        /// </summary>
        [Column(Name = "MiddleName")]
        public string MiddleName { get; set; }
        /// <summary>
        /// Gender ID
        /// </summary>
        [Column(Name = "GenderId")]
        public int GenderId { get; set; }
        /// <summary>
        /// Date of birth
        /// </summary>
        [Column(Name = "DateofBirth")]
        public DateTime DateofBirth { get; set; }
        /// <summary>
        /// Group ID
        /// </summary>
        [Column(Name = "GroupId")]
        public int GroupId { get; set; }
        /// <summary>
        /// Education form ID
        /// </summary>
        [Column(Name = "EducationFormId")]
        public int EducationFormId { get; set; }

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            return $"Id:{Id}, {Name} {Surname} {MiddleName}";
        }
    }
}
