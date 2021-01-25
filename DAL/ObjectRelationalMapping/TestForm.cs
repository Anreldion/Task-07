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
    }
}
