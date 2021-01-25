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
    }
}
