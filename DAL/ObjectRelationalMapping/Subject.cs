using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes subject row
    /// </summary>
    [Table(Name = "Subjects")]
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
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Subject name
        /// </summary>
        [Column(Name = "Name")]
        public string Name { get; set; }
    }
}
