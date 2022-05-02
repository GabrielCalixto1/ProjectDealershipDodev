namespace ProjectDealership.Models
{
    public class Vehicle
    {
        public string Brand {get; set;}
        public string Model {get; set;}
        public DateTime Year {get; set;}
        public int Mileage {get; set;}
        public string Color {get; set;}
        public string Price {get; set;}
        public Vehicle(string brand, string model, DateTime year, int mileage, string color, string price) : base()
        {
            SetBrand(brand);
            SetModel(model);
            SetYear(year);
            SetMileage(mileage);
            SetColor(color);
            SetPrice(price);
        
        }
        public void SetBrand(string brand)
        {
            Brand = brand;
        }
        public string GetBrand()
        {
            return Brand;
        }
        public void SetModel(string model)
        {
            Model = model;
        }
        public string GetModel()
        {
            return Model;
        }
        public void SetYear(DateTime year)
        {
            Year = year;
        }
        public DateTime GetYear()
        {
            return Year;
        }
        public void SetMileage(int mileage)
        {
            Mileage = mileage;
        }
        public int GetMileage()
        {
            return Mileage;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetPrice(string price)
        {
            Price = price;
        }
        public virtual double CalculatePrice()
        {
            return 0;
        }
    }
}