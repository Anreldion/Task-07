using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    /// <summary>
    /// Class describes schedule row
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Subject ID
        /// </summary>
        public int SubjectId { get; set; }
        /// <summary>
        /// Session ID
        /// </summary>
        public int SessionId { get; set; }
        /// <summary>
        /// Group ID
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// TestForm ID
        /// </summary>
        public int TestFormId { get; set; }
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Schedule()
        {
        }
        /// <summary>
        /// Class constructor <see cref="Schedule"/>
        /// </summary>
        /// <param name="date">Date</param>
        /// <param name="subjectId">Subject ID</param>
        /// <param name="sessionId">Session ID</param>
        /// <param name="groupId">Group ID</param>
        /// <param name="testFormId">TestForm ID</param>
        public Schedule(DateTime date, int subjectId, int sessionId, int groupId, int testFormId)
        {
            Date = date;
            SubjectId = subjectId;
            SessionId = sessionId;
            GroupId = groupId;
            TestFormId = testFormId;
        }
        /// <summary>
        /// Class constructor <see cref="Schedule"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="date">Date</param>
        /// <param name="subjectId">Subject ID</param>
        /// <param name="sessionId">Session ID</param>
        /// <param name="groupId">Group ID</param>
        /// <param name="testFormId">TestForm ID</param>
        public Schedule(int id, DateTime date, int subjectId, int sessionId, int groupId, int testFormId)
        {
            Id = id;
            Date = date;
            SubjectId = subjectId;
            SessionId = sessionId;
            GroupId = groupId;
            TestFormId = testFormId;
        }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Schedule schedule &&
                   Id == schedule.Id &&
                   Date == schedule.Date &&
                   SubjectId == schedule.SubjectId &&
                   SessionId == schedule.SessionId &&
                   GroupId == schedule.GroupId &&
                   TestFormId == schedule.TestFormId;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Date, SubjectId, SessionId, GroupId, TestFormId);
        }
    }
}
