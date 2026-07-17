namespace Entities
{
    public abstract class Entity
    {
        public int? Id {get; set;}
        public DateTime CreatedAt {get; private set;} = DateTime.Now;
        public string? Name {get; set;}
    }
}