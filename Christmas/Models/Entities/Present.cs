using System;
using System.Collections.Generic;

namespace Christmas.Models.Entities
{
    public partial class Present
    {
        public int Id { get; set; }
        public int RecieverId { get; set; }
        public string Rhyme { get; set; }

        public virtual Person Reciever { get; set; }
    }
}
