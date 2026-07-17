namespace Models.Response.Register
{
    public abstract record RegisterResponseHuman : RegisterResponse
    {
        public required string email {get; init;}
        public required string cpf {get; init;}
        public required string phone {get; init;}
        public required string address {get; init;}
    }
}