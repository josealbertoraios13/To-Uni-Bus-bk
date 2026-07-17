namespace Models.Request.Register
{
    public record RegisterRequestStudent : RegisterRequestHuman
    {
        public string? RegistrationNumber {get; init;}
        public string? University {get; init;}
        public string? Course {get; init;}
        public IFormFile? ProofOfResidenceUrl {get; init;}
        public IFormFile? EnrollmentDeclaration {get; init;}
    }
}