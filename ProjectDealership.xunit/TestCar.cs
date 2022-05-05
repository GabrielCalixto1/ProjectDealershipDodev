using Xunit;
using ProjectDealership.Models;
namespace ProjectDealership.xunit
{
    public class TestCar
    {
        [Fact]
        public void TestFuelInTheCarClass()
        {
            var expectedFuel = "Full";
            var car = new Car(true, expectedFuel, "Ferrari", "RT8000", System.DateTime.Now, 0, "Red", 1000000);
            var currentFuel = car.GetFuel();
            Assert.Equal(expectedFuel, currentFuel);
        }
            [Fact]
        public void TestAutomaticTransmissionInTheCarClass()
        {
            var expectedAutomaticTransmission = false;
            var car = new Car(expectedAutomaticTransmission, "Empty" , "Lamborgini", "WT5000", System.DateTime.Now, 0, "Yellow", 4500000);
            var currentAutomaticTransmission = car.GetFuel();
            Assert.Equal(expectedAutomaticTransmission, currentAutomaticTransmission);
        }
        
               [Fact]
        public void TestPriceCalculateMethodInTheCarClass()
        {
            double expectedPriceCalculate = 50000;
            var car = new Car(true, "Full" , "Bugatti", "La Voiture Noire", System.DateTime.Now, 0, "Black", expectedPriceCalculate);
            double currentPriceCalculate = car.GetPrice();
            Assert.Equal(expectedPriceCalculate, currentPriceCalculate);
        }
  
  
    }
}