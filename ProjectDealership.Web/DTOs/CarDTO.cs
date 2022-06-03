namespace ProjectDealership.Web.DTOs
{
    public class CarDTO : VehicleDTO
    {
        //changes
        public bool AutomaticTransmission { get; set; }
        public string Fuel { get; set; }
    }
}