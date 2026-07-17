namespace Models.Response.Register
{
    public record RegisterResponseBus : RegisterResponse
    {
        public required string licensePlate {get; init;}
        public required int capacity {get; init;}
    }
}