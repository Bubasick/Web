namespace DAL.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public Owner Owner { get; set; }
        public int OwnerId { get; set; }    
    }
}