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

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Examiner examiners &&
                   Id == examiners.Id &&
                   Name == examiners.Name &&
                   Surname == examiners.Surname &&
                   MiddleName == examiners.MiddleName;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            int hashCode = -458060681;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MiddleName);
            return hashCode;
        }
    }
}
