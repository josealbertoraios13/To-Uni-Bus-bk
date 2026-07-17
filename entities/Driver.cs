namespace Entities
{
    public class Driver : Human
    {
        public Bus? Bus {get; set;}
        public List<Route>? Routes {get; set;}
        public string? Driverlicense {get; set;}
    }
}