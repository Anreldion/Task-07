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
    }
}
