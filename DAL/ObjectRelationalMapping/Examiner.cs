using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes Examiners row
    /// </summary>
    [Table(Name = "Examiners")]
    public class Examiner
    {
        /// <summary>
        /// ID
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Column(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// Surname
        /// </summary>
        [Column(Name = "Surname")]
        public string Surname { get; set; }
        /// <summary>
        /// MiddleName
        /// </summary>
        [Column(Name = "MiddleName")]
        public string MiddleName { get; set; }
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Examiner()
        {
        }
        /// <summary>
        /// Class constructor <see cref="Examiner"/>
        /// </summary>
        /// <param name="name">Examiners name</param>
        /// <param name="surname">Examiners surname</param>
        /// <param name="middleName">Examiners middle name</param>
        public Examiner(string name, string surname, string middleName)
        {
            Name = name;
            Surname = surname;
            MiddleName = middleName;
        }
        /// <summary>
        /// Class constructor <see cref="Examiner"/>
        /// </summary>
        /// <param name="id">Examiners ID</param>
        /// <param name="name">Examiners name</param>
        /// <param name="surname">Examiners surname</param>
        /// <param name="middleName">Examiners middle name</param>
        public Examiner(int id, string name, string surname, string middleName)
        {
            Id = id;
            Name = name;
            Surname = surname;
            MiddleName = middleName;
        }
    }
}
