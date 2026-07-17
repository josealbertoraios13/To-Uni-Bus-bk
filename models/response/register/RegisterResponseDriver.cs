namespace Models.Response.Register
{
    public record RegisterResponseDriver : RegisterResponseHuman
    {
        public required RegisterResponseBus registerResponseBus {get; init;}
        public required List<RegisterResponseRoute> registerResponseRoute {get; init;}
    }
}