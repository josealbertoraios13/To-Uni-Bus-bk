using Util.Route;

namespace Entities
{
    public class Route : Entity
    {
        public LocalPoint? Origin {get; set;}
        public LocalPoint? Destination {get; set;}
        public string? Shift {get; set;}
        public DateTime? DepartureTime {get; set;}
        public List<string> Stops {get; set;} = [];
        public int? DriverId {get; set;}
        public Driver? Driver {get; set;}
    }
}