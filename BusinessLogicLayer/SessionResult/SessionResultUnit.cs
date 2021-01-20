using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.SessionResult
{
    public class SessionResultUnit
    {
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
        /// <inheritdoc cref="object.Equals(object?)"/>
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
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname, MiddleName, Subject, Mark, Date, TestForm);
        }
    }
}
