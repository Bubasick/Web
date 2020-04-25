using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        public ICollection<Computer> Computers { get; set; } = new List<Computer>();
        public string Name { get; set; }    

    }
}
