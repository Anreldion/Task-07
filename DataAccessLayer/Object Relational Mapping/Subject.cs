using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    /// <summary>
    /// Class describes subject row
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Subject()
        {
        }
        /// <summary>
        /// Class constructor <see cref="Subject"/>
        /// </summary>
        /// <param name="name">Subject name</param>
        public Subject(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Class constructor <see cref="Subject"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">Subject name</param>
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Subject name
        /// </summary>
        public string Name { get; set; }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Subject subject &&
                   Id == subject.Id &&
                   Name == subject.Name;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
