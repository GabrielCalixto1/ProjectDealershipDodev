/*using Xunit;
using ProjectDealership.Models;
namespace ProjectDealership.xunit
{
    public class TestMotorcycle
    {
        [Fact]
        public void TestCylindersInTheMotorcycleClass()
        {
            //Arrange
            int expectedCylinders = 300;
            var motorcycle = new Motorcycle(expectedCylinders, "Automatic", "Honda", "CB600", System.DateTime.Now.AddDays(-5), 0, "Black", 15000);
            
            //Act
            int currentCylinders = motorcycle.GetCylinders();

            //Assert
            Assert.Equal(expectedCylinders, currentCylinders);
        }
        [Fact]
        public void TestDepartureInTheMotorcycleClass()
        {
            var expectedDeparture = "Manual";
            var motorcycle = new Motorcycle(300, expectedDeparture, "Honda", "CG150", System.DateTime.Parse("10/10/2005"), 0, "Black", 15000);
            var currentDeparture = motorcycle.GetDeparture();
            Assert.Equal(expectedDeparture, currentDeparture);
        }
        [Fact]
        public void TestPriceCalculateMethodInTheMotorcycleClass()
        {
            double expectedPriceCalculate = 15000;
            var motorcycle = new Motorcycle(300, "Manual", "Honda", "CB300", System.DateTime.Parse("10/10/2005"), 0, "Black", expectedPriceCalculate);
            double currentPriceCalculate = motorcycle.GetPrice();
            Assert.Equal(expectedPriceCalculate, currentPriceCalculate);
        }
    }
}
*/
