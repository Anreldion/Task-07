using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    /// <summary>
    /// Class describes Group row
    /// </summary>
    public class Group
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
        public Group()
        {
        }
        /// <summary>
        /// Class constructor <see cref="Group"/>
        /// </summary>
        /// <param name="name">Group name</param>
        public Group(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Class constructor <see cref="Group"/>
        /// </summary>
        /// <param name="id">Group ID</param>
        /// <param name="name">Group name</param>
        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Group group &&
                   Id == group.Id &&
                   Name == group.Name;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
