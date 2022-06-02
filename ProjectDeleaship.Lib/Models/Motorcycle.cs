using ProjectDeleaship.Lib.Exceptions;
namespace ProjectDeleaship.Lib.Models
{
    public class Motorcycle : Vehicle
    {
        private int Cylinders { get; set; }
        private string Departure { get; set; }
        public Motorcycle(int cylinders, string departure, string brand, string model, string year, int mileage, string color, double price) : base(brand, model, year, mileage, color, price)
        {
            SetCylinders(cylinders);
            SetDeparture(departure);
        }
        public void SetCylinders(int cylinders)
        {
            Cylinders = cylinders;
        }
        public int GetCylinders()
        {
            return Cylinders;
        }
        public void SetDeparture(string departure)
        {
            Departure = departure;
        }
        public string GetDeparture()
        {
            return Departure;
        }
        public override double PriceCalculate()
        {
            var price = Cylinders * 50;

            if (Departure == "Injeção eletrônica")
            {
                price = price + ((price / 100) * 10);
            }
            return GetPrice();
        }
        public override bool PriceValidate(double price)
        {
            if (price > 2000)
            {
                return true;
            }
            return false;
        }


    }
}

