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
    }
}
