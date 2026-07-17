namespace Entities
{
    public class Bus : Entity
    {
        public string? LicensePlate {get; set;}
        public int? Capacity {get; set;}
        public string? Photo {get; set;}
        public Driver? Driver {get; set;}
        public int? DriverId {get; set;}
    }
}