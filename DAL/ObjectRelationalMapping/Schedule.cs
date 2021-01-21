using System;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes schedule row
    /// </summary>
    [Table(Name = "Schedules")]
    public class Schedule
    {
        /// <summary>
        /// ID
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Column(Name = "Date")]
        public DateTime Date { get; set; }
        /// <summary>
        /// Subject ID
        /// </summary>
        [Column(Name = "SubjectId")]
        public int SubjectId { get; set; }
        /// <summary>
        /// Session ID
        /// </summary>
        [Column(Name = "SessionId")]
        public int SessionId { get; set; }
        /// <summary>
        /// Group ID
        /// </summary>
        [Column(Name = "GroupId")]
        public int GroupId { get; set; }
        /// <summary>
        /// TestForm ID
        /// </summary>
        [Column(Name = "TestFormId")]
        public int TestFormId { get; set; }
        /// <summary>
        /// Examiner ID
        /// </summary>
        [Column(Name = "ExaminerID")]
        public int ExaminerID { get; set; }
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
        public Schedule(DateTime date, int subjectId, int sessionId, int groupId, int testFormId, int examinerID)
        {
            Date = date;
            SubjectId = subjectId;
            SessionId = sessionId;
            GroupId = groupId;
            TestFormId = testFormId;
            ExaminerID = examinerID;
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
        public Schedule(int id, DateTime date, int subjectId, int sessionId, int groupId, int testFormId, int examinerID)
        {
            Id = id;
            Date = date;
            SubjectId = subjectId;
            SessionId = sessionId;
            GroupId = groupId;
            TestFormId = testFormId;
            ExaminerID = examinerID;
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
                   TestFormId == schedule.TestFormId &&
                   ExaminerID == schedule.ExaminerID;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            int hashCode = -1561300885;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + SubjectId.GetHashCode();
            hashCode = hashCode * -1521134295 + SessionId.GetHashCode();
            hashCode = hashCode * -1521134295 + GroupId.GetHashCode();
            hashCode = hashCode * -1521134295 + TestFormId.GetHashCode();
            hashCode = hashCode * -1521134295 + ExaminerID.GetHashCode();
            return hashCode;
        }
    }
}
