using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    /// <summary>
    /// Class describes result row
    /// </summary>
    public class Result
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Session ID
        /// </summary>
        public int SessionId { get; set; }
        /// <summary>
        /// Subject ID
        /// </summary>
        public int SubjectId { get; set; }
        /// <summary>
        /// Student ID
        /// </summary>
        public int StudentId { get; set; }
        /// <summary>
        /// Mark
        /// </summary>
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

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Result result &&
                   Id == result.Id &&
                   SessionId == result.SessionId &&
                   SubjectId == result.SubjectId &&
                   StudentId == result.StudentId &&
                   Mark == result.Mark;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, SessionId, SubjectId, StudentId, Mark);
        }
    }
}
