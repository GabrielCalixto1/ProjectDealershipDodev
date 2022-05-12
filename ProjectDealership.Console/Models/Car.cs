namespace ProjectDealership.Models
{
    public class Car : Vehicle
    {
        public bool AutomaticTransmission { get; set; }
        public string Fuel { get; set; }
        public Car(bool automaticTransmission, string fuel, string brand, string model, DateTime year, int mileage, string color, double price) : base(brand, model, year, mileage, color, price)
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
          public override double PriceCalculate()
        {
          if(AutomaticTransmission)
          {
            SetPrice(GetPrice()*1.2);    
          }
          return GetPrice();
        }

    }

}
