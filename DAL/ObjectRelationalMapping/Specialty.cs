using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes Specialty row
    /// </summary>
    [Table(Name = "Specialties")]
    public class Specialty
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
        public Specialty()
        {
        }
        /// <summary>
        /// Class constructor <see cref="Specialty"/>
        /// </summary>
        /// <param name="name">Specialty name</param>
        public Specialty(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Class constructor <see cref="Specialty"/>
        /// </summary>
        /// <param name="id">Specialty ID</param>
        /// <param name="name">Specialty name</param>
        public Specialty(int id, string name)
        {
            Id = id;
            Name = name;
        }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Specialty Specialty &&
                   Id == Specialty.Id &&
                   Name == Specialty.Name;
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
