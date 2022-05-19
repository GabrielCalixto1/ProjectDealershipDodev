using Xunit;
using ProjectDealership.Models;
namespace ProjectDealership.xunit
{
    public class TestEmployee
    {
        [Fact]
        public void TestPositionInTheEmployeeClass()
        {
            var expectedPosition = "Gerente";
            var employee = new Employee(expectedPosition, "Gabriel", "54545545", System.DateTime.Now.AddDays(-5));
            var currentPosition = employee.GetPosition();
            Assert.Equal(expectedPosition, currentPosition);
        }
    }
}
