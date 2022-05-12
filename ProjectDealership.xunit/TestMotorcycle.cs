/* using Xunit;
using ProjectDealership.Models;
namespace ProjectDealership.xunit
{
    public class TestMotorcycle
    {
        [Fact]
           public void TestCylindersInTheMotorcycleClass()
        {
            var expectedCylinders = 300;
            var motorcycle = new Motorcycle(expectedCylinders, "Automatic", "Honda", "CB600", System.DateTime.Now, 0, "Black", 15000);
            double currentCylinders = motorcycle.GetCylinders();
            Assert.Equal(expectedCylinders, currentCylinders);
        }
        [Fact]
           public void TestDepartureInTheMotorcycleClass()
        {
            var expectedDeparture = "Manual";
            var motorcycle = new Motorcycle(300, expectedDeparture, "Honda", "CG150", System.DateTime.Now, 0, "Black", 15000);
            var currentDeparture = motorcycle.GetDeparture();
            Assert.Equal(expectedDeparture, currentDeparture);
        }
        [Fact]
             public void TestPriceCalculateMethodInTheMotorcycleClass()
        {
            double expectedPriceCalculate = 15000;
            var motorcycle = new Motorcycle(300, "Manual", "Honda", "CB300", System.DateTime.Now, 0, "Black", expectedPriceCalculate);
            double currentPriceCalculate = motorcycle.GetPrice();
            Assert.Equal(expectedPriceCalculate, currentPriceCalculate);
        }
        }
    }
}*/