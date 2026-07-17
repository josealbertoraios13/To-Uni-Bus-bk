namespace Models.Request.Register
{
    public abstract record RegisterRequestHuman : RegisterRequest
    {
        public string? Email {get; init;}
        public string? Cpf {get; init;}
        public string? Phone {get; init;}
        public string? Address {get; init;}
        public IFormFile? Identity {get; init;}
        public IFormFile? Photo {get; init;}
        public string? Password {get; init;}
        public string? ConfirmPassword {get; init;}
    }
}