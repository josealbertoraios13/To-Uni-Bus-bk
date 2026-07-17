namespace Models.Response.Register
{
    public record RegisterResponseAdministrator : RegisterResponseHuman
    {
        public required string code {get; init;}
    }
}