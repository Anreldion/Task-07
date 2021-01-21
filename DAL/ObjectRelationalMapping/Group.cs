using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes Group row
    /// </summary>
    [Table(Name = "Groups")]
    public class Group
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
        /// Specialties ID
        /// </summary>
        [Column(Name = "SpecialtiesID")]
        public int SpecialtiesID { get; set; }
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
        public Group(string name, int specialtiesID)
        {
            Name = name;
            SpecialtiesID = specialtiesID;
        }
        /// <summary>
        /// Class constructor <see cref="Group"/>
        /// </summary>
        /// <param name="id">Group ID</param>
        /// <param name="name">Group name</param>
        public Group(int id, string name, int specialtiesID)
        {
            Id = id;
            Name = name;
            SpecialtiesID = specialtiesID;
        }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Group group &&
                   Id == group.Id &&
                   Name == group.Name &&
                   SpecialtiesID == group.SpecialtiesID;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            int hashCode = -1554455872;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + SpecialtiesID.GetHashCode();
            return hashCode;
        }
    }
}
