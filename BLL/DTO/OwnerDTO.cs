using System.Collections.Generic;

namespace BLL.DTO
{
    public class OwnerDTO
    {
        public int Id { get; set; }
        public ICollection<ComputerDTO> Computers { get; set; } = new List<ComputerDTO>();
        public string Name { get; set; }
    }
}
