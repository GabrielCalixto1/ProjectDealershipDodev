namespace ProjectDealership.Web.DTOs
{
    public class CarDTO : VehicleDTO
    {
        public bool AutomaticTransmission { get; set; }
        public string Fuel { get; set; }
    }
}