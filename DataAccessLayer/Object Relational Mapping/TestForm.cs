using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    /// <summary>
    /// Class describes test form row
    /// </summary>
    public class TestForm
    {
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public TestForm()
        {
        }
        /// <summary>
        /// Class constructor <see cref="TestForm"/>
        /// </summary>
        /// <param name="name">Test form name</param>
        public TestForm(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Class constructor <see cref="TestForm"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name"></param>
        public TestForm(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Test form name
        /// </summary>
        public string Name { get; set; }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is TestForm form &&
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
