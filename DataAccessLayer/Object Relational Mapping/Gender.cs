using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    /// <summary>
    /// Class describes Gender row
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gender type name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Gender()
        {
        }
        /// <summary>
        /// Class constructor <see cref="Gender"/>
        /// </summary>
        /// <param name="name">Gender name</param>
        public Gender(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Class constructor <see cref="Gender"/>
        /// </summary>
        /// <param name="id">Gender ID</param>
        /// <param name="name">Gender name</param>
        public Gender(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Gender gender &&
                   Id == gender.Id &&
                   Name == gender.Name;
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
