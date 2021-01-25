using System;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes result row
    /// </summary>
    [Table(Name = "Results")]
    public class Result
    {
        /// <summary>
        /// ID
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Session ID
        /// </summary>
        [Column(Name = "SessionId")]
        public int SessionId { get; set; }
        /// <summary>
        /// Subject ID
        /// </summary>
        [Column(Name = "SubjectId")]
        public int SubjectId { get; set; }
        /// <summary>
        /// Student ID
        /// </summary>
        [Column(Name = "StudentId")]
        public int StudentId { get; set; }
        /// <summary>
        /// Mark
        /// </summary>
        [Column(Name = "Mark")]
        public int Mark { get; set; }
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Result()
        {
        }
        /// <summary>
        /// Class constructor <see cref="Result"/>
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="subjectId">Subject ID</param>
        /// <param name="studentId">Student ID</param>
        /// <param name="mark">Mark</param>
        public Result(int sessionId, int subjectId, int studentId, int mark)
        {
            SessionId = sessionId;
            SubjectId = subjectId;
            StudentId = studentId;
            Mark = mark;
        }
        /// <summary>
        /// Class constructor <see cref="Result"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="sessionId">Session ID</param>
        /// <param name="subjectId">Subject ID</param>
        /// <param name="studentId">Student ID</param>
        /// <param name="mark">Mark</param>
        public Result(int id, int sessionId, int subjectId, int studentId, int mark)
        {
            Id = id;
            SessionId = sessionId;
            SubjectId = subjectId;
            StudentId = studentId;
            Mark = mark;
        }
    }
}
