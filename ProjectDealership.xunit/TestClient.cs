using Xunit;
using ProjectDeleaship.Lib.Models;
using ProjectDeleaship.Lib.Exceptions;
namespace ProjectDealership.xunit
{
    public class TestClient
    {
          [Fact]
        public void TestEmailInTheClientClass()
        {
            var expectedEmail = "test@test.com";
            var client = new Client(expectedEmail, "Gabriel", "155223332621", System.DateTime.Now.AddDays(-2), "988888888");
             var currentEmail = client.GetEmail();
            Assert.Equal(expectedEmail, currentEmail);
        }
  
          [Fact]
        public void TestTelephoneInTheClientClass()
        {
            var expectedTelephone = "988888888";
            var client = new Client("test@test.com", "Gabriel", "155223332621", System.DateTime.Now.AddDays(-2), expectedTelephone);
            var currentTelephone = client.GetTelephone();
            Assert.Equal(expectedTelephone, currentTelephone);
        }
    
    }
}