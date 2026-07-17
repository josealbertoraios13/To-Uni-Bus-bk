namespace Models.Response.Login
{
    public record AuthenticatedUserResponse
    {
        public required int id {get; init;}
        public required string name {get; init;}
        public required string email {get; init;}
        public required string cpf {get; init;}
        public required string address {get; init;}
        public required string phone {get; init;}
        public required string registrationNumber {get; init;}
        public required string university {get; init;}
        public required string course {get; init;} 
        public required string status {get; init;}
    }
}