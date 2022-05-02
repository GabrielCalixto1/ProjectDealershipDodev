namespace ProjectDealership.Models
{
    public class Car : Vehicle
    {
        private bool AutomaticTransmission { get; set; }
        private string Fuel { get; set; }
        public Car(bool automaticTransmission, string fuel, string brand, string model, DateTime year, int mileage, string color, string price) : base(brand, model, year, mileage, color, price)
        {
          SetAutomaticTransmission(automaticTransmission);
          SetFuel(fuel);
        }

        public void SetAutomaticTransmission(bool automaticTransmission)
        {
            AutomaticTransmission = automaticTransmission;
        }
        public bool GetAutomaticTransmission()
        {
            return AutomaticTransmission;
        }
        public void SetFuel(string fuel)
        {
            Fuel = fuel;
        }
        public string GetFuel()
        {
            return Fuel;
        }
          public override double CalculatePrice()
        {
            return 0;
        }

    }

}
