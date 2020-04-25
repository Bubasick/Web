using System;
using System.Collections.Generic;

namespace BLL.DTO
{
   public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<PartDTO> PartsForReplacement { get; set; } = new List<PartDTO>();
        public OwnerDTO Owner { get; set; }
        public int OwnerId { get; set; }
        public decimal Price { get; set; }  

    }
}