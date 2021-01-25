using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.SessionResult
{
    /// <summary>
    /// A class containing information about a student's grade.
    /// </summary>
    public class SessionResultUnit
    {
        /// <summary>
        /// Class constructor <see cref="SessionResultUnit"/>
        /// </summary>
        /// <param name="name">Student name</param>
        /// <param name="surname">Student surname</param>
        /// <param name="middleName">Student middleName</param>
        /// <param name="subject">Subject</param>
        /// <param name="mark">Mark</param>
        /// <param name="date">Completion date</param>
        /// <param name="testForm">Test form</param>
        public SessionResultUnit(string name, string surname, string middleName, string subject, int mark, DateTime date, string testForm)
        {
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            Subject = subject;
            Mark = mark;
            Date = date;
            TestForm = testForm;
        }

        /// <summary>
        /// Student name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Student surname.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Student middleName.
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Subject.
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Mark.
        /// </summary>
        public int Mark { get; set; }
        /// <summary>
        /// Completion date.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Test form.
        /// </summary>
        public string TestForm { get; set; }
        
        public override bool Equals(object obj)
        {
            return obj is SessionResultUnit unit &&
                   Name == unit.Name &&
                   Surname == unit.Surname &&
                   MiddleName == unit.MiddleName &&
                   Subject == unit.Subject &&
                   Mark == unit.Mark &&
                   Date == unit.Date &&
                   TestForm == unit.TestForm;
        }

        public override int GetHashCode()
        {
            int hashCode = 1730571862;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MiddleName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Subject);
            hashCode = hashCode * -1521134295 + Mark.GetHashCode();
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TestForm);
            return hashCode;
        }
    }
}
