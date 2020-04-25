using System;

namespace DAL.Entities
{
    public class Part
    {
        public int Id { get; set;}
        public string PartName { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}