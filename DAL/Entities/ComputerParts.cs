using System.Collections.Generic;

namespace DAL.Entities
{
    public class ComputerParts
    {
        public int Id { get; set; }
        public Computer Computer { get; set; }
        public ICollection<Part> Parts { get; set; }

    }
}