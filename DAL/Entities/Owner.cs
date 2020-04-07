using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        public List<Computer> Computers { get; set; } = new List<Computer>();

    }
}
