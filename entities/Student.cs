namespace Entities
{    
    public class Student : Human
    {
        public string? RegistrationNumber {get; set;}
        public string? University {get; set;} 
        public string? Course {get; set;}
        public string? ProofOfResidenceUrl {get; set;}
        public string? EnrollmentDeclaration {get; set;}
    }
}