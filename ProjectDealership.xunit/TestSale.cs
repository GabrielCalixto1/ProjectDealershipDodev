using Xunit;
using ProjectDealership.Models;
namespace ProjectDealership.xunit
{
    public class TestSale

    {

        [Fact]
        public void TestBuyerInTheSaleClass()
        {
            Client expectedBuyer = new Client("Test@dodev.com.br", "Gabriel", "1521651", System.DateTime.Now, "328484848");
            Employee seller = new Employee("Gerente", "Giovanni", "5645432", System.DateTime.Now);
            Vehicle vehicle = new Vehicle("Bugatti", "Ixv99", System.DateTime.Now, 0, "Purple", 800000);
            var sale = new Sale(expectedBuyer, seller, vehicle, "Cartão", 5000);
            var currentBuyer = sale.GetBuyer();
            Assert.Equal(expectedBuyer, currentBuyer);
        }
        [Fact]
        public void TestSellerInTheSaleClass()
        {
            Client buyer = new Client("Test@outlook.com", "Gabriel", "1521651", System.DateTime.Now, "229848448");
            Employee expectedSeller = new Employee("Gerente", "Giovanni", "5645432", System.DateTime.Now);
            Vehicle vehicle = new Vehicle("Ferrari", "xt200", System.DateTime.Now, 0, "Black", 800000);
            var sale = new Sale(buyer, expectedSeller, vehicle, "Cartão", 5000);
            var currentSeller = sale.GetSeller();
            Assert.Equal(expectedSeller, currentSeller);
        }
        [Fact]
        public void TestSaleInTheSaleClass()
        {
            Client buyer = new Client("Test@yahoo.com", "Gabriel", "1521651", System.DateTime.Now, "329984488");
            Employee seller = new Employee("Gerente", "Giovanni", "5645432", System.DateTime.Now);
            Vehicle expectedVehicle = new Vehicle("Mercedes Benz", "Partthura", System.DateTime.Now, 0, "Green", 800000);
            var sale = new Sale(buyer, seller, expectedVehicle, "Cartão", 5000);
            var currentVehicle = sale.GetVehicle();
            Assert.Equal(expectedVehicle, currentVehicle);
        }
        [Fact]
        public void TestPaymentMethodInTheSaleClass()
        {
            Client buyer = new Client("Test@hotmail.com", "Gabriel", "1521651", System.DateTime.Now, "119184848");
            Employee seller = new Employee("Gerente", "Giovanni", "5645432", System.DateTime.Now);
            Vehicle vehicle = new Vehicle("Tesla", "1", System.DateTime.Now, 0, "Black", 800000);
            var expectedPaymentMethod = "Dinheiro";
            var sale = new Sale(buyer, seller, vehicle, expectedPaymentMethod, 5000);
            var currentPaymentMethod = sale.GetPaymentMethod();
            Assert.Equal(expectedPaymentMethod, currentPaymentMethod);
        }
        [Fact]
        public void TestFinalAmountInTheSaleClass()
        {
            Client buyer = new Client("Test@gmail.com", "Gabriel", "1521651", System.DateTime.Now, "1172484848");
            Employee seller = new Employee("Gerente", "Giovanni", "5645432", System.DateTime.Now);
            Vehicle vehicle = new Vehicle("Bugatti", "Ixv99", System.DateTime.Now, 0, "Purple", 800000);
            var expectedFinalAmount = 50000;
            var sale = new Sale(buyer, seller, vehicle, "Cartão", expectedFinalAmount);
            var currentFinalAmount = sale.GetFinalAmount();
            Assert.Equal(expectedFinalAmount, currentFinalAmount);
        }
    }
}