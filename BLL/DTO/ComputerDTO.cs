namespace BLL.DTO
{
    public class ComputerDTO
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public OwnerDTO Owner { get; set; }
        public int OwnerId { get; set; }    
    }
}