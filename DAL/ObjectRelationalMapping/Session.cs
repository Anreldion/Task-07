using System;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes session row
    /// </summary>
    [Table(Name = "Sessions")]
    public class Session
    {
        /// <summary>
        /// ID
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Session period ID
        /// </summary>
        [Column(Name = "SessionPeriodId")]
        public int SessionPeriodId { get; set; }
        /// <summary>
        /// Session date from
        /// </summary>
        [Column(Name = "DateFrom")]
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Session date to
        /// </summary>
        [Column(Name = "DateTo")]
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
            int hashCode = -548053044;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + SessionPeriodId.GetHashCode();
            hashCode = hashCode * -1521134295 + DateFrom.GetHashCode();
            hashCode = hashCode * -1521134295 + DateTo.GetHashCode();
            return hashCode;
        }
    }
}
