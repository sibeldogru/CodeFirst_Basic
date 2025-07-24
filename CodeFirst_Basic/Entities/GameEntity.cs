namespace CodeFirst_Basic.Entities
{
    public class GameEntity : BaseEntity 
    {
        public string Name { get; set; }
        public string Platform { get; set; }

        public decimal Rating { get; set; }
    }
}
