namespace Models.Request.Register
{
    public record RegisterRequestAdministrator : RegisterRequestHuman
    {
        public string? Code {get; init;}
    }
}