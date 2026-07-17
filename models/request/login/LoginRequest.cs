namespace Models.Request.Login
{
    public record LoginRequest
    {
        public string? identifier { get; init; }
        public string? password { get; init; }
    }
}