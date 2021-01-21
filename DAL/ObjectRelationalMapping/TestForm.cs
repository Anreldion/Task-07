using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace DataAccessLayer.ObjectRelationalMapping
{
    /// <summary>
    /// Class describes test form row
    /// </summary>
    [Table(Name = "TestForms")]
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
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Test form name
        /// </summary>
        [Column(Name = "Name")]
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
            int hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
