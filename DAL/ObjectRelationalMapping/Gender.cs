using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes Gender row
    /// </summary>
    [Table(Name = "Genders")]
    public class Gender
    {
        /// <summary>
        /// ID
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Gender type name
        /// </summary>
        [Column(Name = "Name")]
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
            int hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
