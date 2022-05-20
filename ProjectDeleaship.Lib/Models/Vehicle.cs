using ProjectDeleaship.Lib.Exceptions;
namespace ProjectDeleaship.Lib.Models
{
    public class Vehicle
    {
        protected string Brand { get; set; }
        protected string Model { get; set; }
        protected DateTime Year { get; set; }
        protected int Mileage { get; set; }
        protected string Color { get; set; }
        protected double Price { get; set; }
        public Vehicle(string brand, string model, string year, int mileage, string color, double price)
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
        public void SetYear(string year)
        {
            YearValidation(year);
            Year = DateTime.Parse(year);
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
            PriceValidate(price);
            Price = price;

        }
        public double GetPrice()
        {
            return Price;
        }
        public virtual double PriceCalculate()
        {
            return 0;
        }
        public bool YearValidation(string year)
        {

            var date = DateTime.Parse(year);
            if (date >= DateTime.Parse(year) && date < DateTime.Now)
            {
                return true;
            }
            throw new ValidationErrorException("Data inválida");
        }
        public virtual bool PriceValidate(double price)
        {
            if (price > 9000)
            {
                return true;
            }
            throw new ValidationErrorException("Valor inválido");
        }

    }
}