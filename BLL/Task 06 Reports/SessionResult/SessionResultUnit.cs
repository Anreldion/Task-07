using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.SessionResult
{
    /// <summary>
    /// 
    /// </summary>
    public class SessionResultUnit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="middleName"></param>
        /// <param name="subject"></param>
        /// <param name="mark"></param>
        /// <param name="date"></param>
        /// <param name="testForm"></param>
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
