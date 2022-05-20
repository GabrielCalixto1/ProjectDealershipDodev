using Xunit;
using ProjectDeleaship.Lib.Models;
using ProjectDeleaship.Lib.Exceptions;
namespace ProjectDealership.xunit
{
    public class TestPerson
    {
        [Fact]
           public void TestNameInThePersonClass()
        {
            var expectedName = "Gabriel";
            var person = new Person(expectedName, "51651651", System.DateTime.Now.AddDays(-2));
            var currentName = person.GetName();
            Assert.Equal(expectedName, currentName);
        }
        [Fact]
           public void TestCpfInThePersonClass()
        {
            var expectedCpf = "165465146";
            var person = new Person("Gabriel", expectedCpf, System.DateTime.Now.AddDays(-2));
            var currentCpf = person.GetCpf();
            Assert.Equal(expectedCpf, currentCpf);
        }
     [Fact]
           public void TestBirthdateInThePersonClass()
        {
            var expectedBirthdate = "01/01/2000";
        
            var person = new Person("Gabriel", "51651651", System.DateTime.Parse(expectedBirthdate));
            var currentBirthdate = person.GetBirthdate();
            Assert.Equal(expectedBirthdate, currentBirthdate.ToString("dd/MM/yyyy"));
        }

    }
}