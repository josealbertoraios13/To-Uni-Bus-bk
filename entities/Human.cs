namespace Entities
{
    public abstract class Human : Entity
    {
        public string? Email {get; set;}
        public string? Cpf {get; set;} 
        public string? Phone {get; set;}
        public string? Address {get; set;}
        public string? Identity {get; set;}
        public string? Photo {get; set;}
        public string? Password {get; set;}
    }
}