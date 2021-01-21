using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes education form row
    /// </summary>
    [Table(Name = "EducationForms")]
    public class EducationForm
    {
        /// <summary>
        /// ID
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Form of education name.
        /// </summary>
        [Column(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public EducationForm()
        {
        }
        /// <summary>
        /// Class constructor <see cref="EducationForm"/>
        /// </summary>
        /// <param name="name">Form of education name</param>
        public EducationForm(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Class constructor <see cref="EducationForm"/>
        /// </summary>
        /// <param name="id">Form of education ID</param>
        /// <param name="name">Form of education name</param>
        public EducationForm(int id, string name)
        {
            Id = id;
            Name = name;
        }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is EducationForm form &&
                   Id == form.Id &&
                   Name == form.Name;
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
