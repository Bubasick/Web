using System.Collections.Generic;

namespace BLL.DTO
{
    public class ComputerPartsDTO
    {
        public int Id { get; set; }
        public ComputerDTO Computer { get; set; }
        public ICollection<PartDTO> Parts { get; set; }

    }
}