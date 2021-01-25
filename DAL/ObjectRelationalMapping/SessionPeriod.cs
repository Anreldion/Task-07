using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes session period row
    /// </summary>
    [Table(Name = "SessionPeriods")]
    public class SessionPeriod
    {
        /// <summary>
        /// ID
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Session period name.
        /// </summary>
        [Column(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public SessionPeriod()
        {
        }
        /// <summary>
        /// Class constructor <see cref="SessionPeriod"/>
        /// </summary>
        /// <param name="name">Session period name.</param>
        public SessionPeriod(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Class constructor <see cref="SessionPeriod"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">Session period name.</param>
        public SessionPeriod(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
