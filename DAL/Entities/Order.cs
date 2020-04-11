using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DAL.Entities
{
   public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Part> PartsForReplacement { get; set; } = new List<Part>();
        public Owner Owner { get; set; }
        public int OwnerId { get; set; }    

    }
}