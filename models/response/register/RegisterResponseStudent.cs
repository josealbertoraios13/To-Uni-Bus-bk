namespace Models.Response.Register
{
    public record RegisterResponseStudent : RegisterResponseHuman
    {
        public required string registrationNumber {get; init;}
        public required string university {get; init;}
        public required string course {get; init;}
    }
}