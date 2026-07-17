namespace Models.Request.Register
{
    public record RegisterRequestDriver : RegisterRequestHuman
    {
        public IFormFile? Driverlicense {get; set;}
    }
}