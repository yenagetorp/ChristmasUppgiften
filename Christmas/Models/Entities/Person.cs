using System;
using System.Collections.Generic;

namespace Christmas.Models.Entities
{
    public partial class Person
    {
        public Person()
        {
            Present = new HashSet<Present>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Present> Present { get; set; }
    }
}
