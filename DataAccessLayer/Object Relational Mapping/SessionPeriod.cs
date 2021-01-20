using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    /// <summary>
    /// Class describes session period row
    /// </summary>
    public class SessionPeriod
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Session period name.
        /// </summary>
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
            return HashCode.Combine(Id, Name);
        }
    }
}
