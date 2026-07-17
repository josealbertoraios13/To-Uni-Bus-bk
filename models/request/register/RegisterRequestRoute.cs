using Util.Route;

namespace Models.Request.Register
{
    public record RegisterRequestRoute : RegisterRequest
    {
        public LocalPoint? Origin {get; init;} 
        public LocalPoint? Destination {get; init;} 
        public string? Shift {get; init;}
        public string? DepartureTime {get; init;}
        public List<string>? Stops {get; init;}
        public int? DriverId {get; init;}
    }
}