using Xunit;
using ProjectDealership.Models;
namespace ProjectDealership.xunit
{
    public class TestVehicle
    {
        [Fact]
        public void TestBrandInTheVehicleClass()
        {
            var expectedBrand = "test";
            var vehicle = new Vehicle(expectedBrand, "RT300", System.DateTime.Now, 0, "Blue", 50000);
            var currentBrand = vehicle.GetBrand();
            Assert.Equal(expectedBrand, currentBrand);
        }
        [Fact]
        public void TestModelInTheVehicleClass()
        {
            var expectedModel = "Civic";
            var vehicle = new Vehicle("Honda", expectedModel, System.DateTime.Now, 0, "Silver", 50000);
            var currentModel = vehicle.GetModel();
            Assert.Equal(expectedModel, expectedModel);
        }
        [Fact]
        public void TestYearInTheVehicleClass()
        {
            var expectedYear = "01/01/2000";
            var vehicle = new Vehicle("Fiat", "Palio", System.DateTime.Parse(expectedYear), 0, "Black", 50000);
            var currentYear = vehicle.GetYear().ToString("dd/MM/yyyy");
            Assert.Equal(expectedYear, currentYear);
        }
        [Fact]
        public void TestMileageInTheVehicleClass()
        {
            var expectedMileage = 0;
            var vehicle = new Vehicle("Fiat", "Uno mile", System.DateTime.Now, expectedMileage, "Red", 50000);
            var currentMileage = vehicle.GetMileage();
            Assert.Equal(expectedMileage, currentMileage);
        }
        [Fact]
        public void TestColorInTheVehicleClass()
        {
            var expectedColor = "Red";
            var vehicle = new Vehicle("Mercedes Benz", "Tchala", System.DateTime.Now, 0, expectedColor, 50000);
            var currentColor = vehicle.GetColor();
            Assert.Equal(expectedColor, currentColor);
        }
        [Fact]
        public void TestPriceInTheVehicleClass()
        {
            var expectedPrice = 500000;
            var vehicle = new Vehicle("BMW", "BMLL", System.DateTime.Now, 0, "Gold", expectedPrice);
            var currentPrice = vehicle.GetPrice();
            Assert.Equal(expectedPrice, currentPrice);
        }
    }
}