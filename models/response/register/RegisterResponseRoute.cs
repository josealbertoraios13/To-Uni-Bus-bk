using Util.Route;

namespace Models.Response.Register
{
    public record RegisterResponseRoute : RegisterResponse
    {
        public required LocalPoint origin {get; init;}
        public required LocalPoint destination {get; init;}
        public required string shift {get; init;}
        public required string departureTime {get; init;}
        public required List<string> stops {get; init;}
    }
}