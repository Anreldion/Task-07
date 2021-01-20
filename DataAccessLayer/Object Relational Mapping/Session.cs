using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    /// <summary>
    /// Class describes session row
    /// </summary>
    public class Session
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Session period ID
        /// </summary>
        public int SessionPeriodId { get; set; }
        /// <summary>
        /// Session date from
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Session date to
        /// </summary>
        public DateTime DateTo { get; set; }
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Session()
        {
        }
        /// <summary>
        /// Class constructor <see cref="Session"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="sessionPeriodId">Session period ID</param>
        /// <param name="from">Session date from</param>
        /// <param name="to">Session date to</param>
        public Session(int id, int sessionPeriodId, DateTime from, DateTime to)
        {
            Id = id;
            SessionPeriodId = sessionPeriodId;
            DateFrom = from;
            DateTo = to;
        }
        /// <summary>
        /// Class constructor <see cref="Session"/>
        /// </summary>
        /// <param name="sessionPeriodId">Session period ID</param>
        /// <param name="from">Session date from</param>
        /// <param name="to">Session date to</param>
        public Session(int sessionPeriodId, DateTime from, DateTime to)
        {
            SessionPeriodId = sessionPeriodId;
            DateFrom = from;
            DateTo = to;
        }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Session session &&
                   Id == session.Id &&
                   SessionPeriodId == session.SessionPeriodId &&
                   DateFrom == session.DateFrom &&
                   DateTo == session.DateTo;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, SessionPeriodId, DateFrom, DateTo);
        }
    }
}
