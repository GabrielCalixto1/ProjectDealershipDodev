using Xunit;
using ProjectDeleaship.Lib.Models;
using System;
using ProjectDeleaship.Lib.Exceptions;

namespace ProjectDealership.xunit
{
    public class TestVehicle
    {
        [Fact]
        public void TestBrandInTheVehicleClass()
        {
            var expectedBrand = "Fiat";
            var vehicle = CreateDefaultVehicle();
            vehicle.SetBrand(expectedBrand);
            var currentBrand = vehicle.GetBrand();
            Assert.Equal(expectedBrand, currentBrand);
        }
        [Fact]
        public void TestModelInTheVehicleClass()
        {
            var expectedModel = "Palio";
            var vehicle = CreateDefaultVehicle();
            vehicle.SetModel(expectedModel);
            var currentModel = vehicle.GetModel();
            Assert.Equal(expectedModel, expectedModel);
        }
        [Fact]
        public void TestYearInTheVehicleClass()
        {
            var expectedYear = "01/01/2007";
            var vehicle = CreateDefaultVehicle();
            vehicle.SetYear(expectedYear);
            var currentYear = vehicle.GetYear().ToString("dd/MM/yyyy");
            Assert.Equal(expectedYear, currentYear);
        }
        [Fact]
        public void TestMileageInTheVehicleClass()
        {
            var expectedMileage = 0;
            var vehicle = CreateDefaultVehicle();
            vehicle.SetMileage(expectedMileage);
            var currentMileage = vehicle.GetMileage();
            Assert.Equal(expectedMileage, currentMileage);
        }
        [Fact]
        public void TestColorInTheVehicleClass()
        {
            var expectedColor = "Red";
            var vehicle = CreateDefaultVehicle();
            vehicle.SetColor(expectedColor);
            var currentColor = vehicle.GetColor();
            Assert.Equal(expectedColor, currentColor);
        }
        [Fact]
        public void TestPriceInTheVehicleClass()
        {
            var expectedPrice = 15000;
            var vehicle = CreateDefaultVehicle();
            vehicle.SetPrice(expectedPrice);
            double currentPrice = vehicle.GetPrice();
            Assert.Equal(expectedPrice, currentPrice);
        }
             [Fact]
        public void VehicleMustNotHaveYearLessThan2004()
        {
            var expectedYear = "01/01/2000";
            var vehicle = CreateDefaultVehicle();
            Assert.Throws<ValidationErrorException>(() => new Vehicle("1", "1", expectedYear, 0, "1", 15000) );                
        }
                [Fact]
        public void VehicleMustNotHaveYearLessThanActual()
        {
            var expectedYear = DateTime.Now.AddDays(2).ToString();
            var vehicle = CreateDefaultVehicle();
            Assert.Throws<ValidationErrorException>(() => new Vehicle("1", "1", expectedYear, 0, "1", 15000) ); 
                     
        }

        public Vehicle CreateDefaultVehicle()
        {
            return new Vehicle("Honda", "Civic", "01/01/2005", 50, "Silver", 22000);
        }

    }
}