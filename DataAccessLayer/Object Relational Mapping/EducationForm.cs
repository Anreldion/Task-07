using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    /// <summary>
    /// Class describes education form row
    /// </summary>
    public class EducationForm
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Form of education name.
        /// </summary>
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
            return HashCode.Combine(Id, Name);
        }
    }
}
