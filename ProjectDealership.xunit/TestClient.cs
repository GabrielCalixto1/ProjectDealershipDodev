using Xunit;
using ProjectDealership.Models;
namespace ProjectDealership.xunit
{
    public class TestClient
    {
          [Fact]
        public void TestEmailInTheClientClass()
        {
            var expectedEmail = "test@test.com";
            var client = new Client(expectedEmail, "Gabriel", "155255355", System.DateTime.Now, "9984984");
             var currentEmail = client.GetEmail();
            Assert.Equal(expectedEmail, currentEmail);
        }
          [Fact]
        public void TestTelephoneInTheClientClass()
        {
            var expectedTelephone = "88591945";
            var client = new Client("test@test.com", "Gabriel", "155255355", System.DateTime.Now, expectedTelephone);
            var currentTelephone = client.GetTelephone();
            Assert.Equal(expectedTelephone, currentTelephone);
        }
    
    }
}