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
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is SessionPeriod period &&
                   Id == period.Id &&
                   Name == period.Name;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            int hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
