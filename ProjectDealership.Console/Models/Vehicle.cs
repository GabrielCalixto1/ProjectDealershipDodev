using ProjectDealership.Exceptions;
namespace ProjectDealership.Models
{
    public class Vehicle
    {
        public string Brand {get; set;}
        public string Model {get; set;}
        public DateTime Year {get; set;}
        public int Mileage {get; set;}
        public string Color {get; set;}
        public double Price {get; set;}
        public Vehicle(string brand, string model, DateTime year, int mileage, string color, double price) : base()
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
        public void SetPrice(double price)
        {
            if(PriceValidate(price))
            {
               Price = price; 
            }
            throw new ValidationErrorException("Valor inválido");
        }
        public double GetPrice()
        {
            return Price;
        }
        public virtual double PriceCalculate()
        {
            return 0;
        }
            public bool YearValidation(DateTime year)
        {

            if (year > DateTime.Parse("01/01/2004") && year < DateTime.Now)
            {
                return true;
            }
            return false;
        }
            public virtual bool PriceValidate(double price)
        {
            if (price > 0)
            {
                return true;
            }
            return false;
        }

    }
}