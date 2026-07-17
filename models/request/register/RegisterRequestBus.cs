namespace Models.Request.Register
{
    public record RegisterRequestBus : RegisterRequest
    {
        public string? LicensePlate {get; init;}
        public int? Capacity {get; init;}
        public IFormFile? Photo {get; init;}
        public int? DriverId {get; init;}
    }
}