using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DAL.Entities
{
   public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Part> PartsForReplacement { get; set; } = new List<Part>();

    }
}