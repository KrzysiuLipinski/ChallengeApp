using System.Reflection.Metadata;
using System.Xml.Linq;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenNumbersAreNotEqual()
        {
            int number1 = 2;
            int number2 = 3;
            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void WhenNamesAreNotEqual()
        {
            string name1 = "Krzysztof";
            string name2 = "Marek";

            Assert.AreNotEqual(name1, name2);
        }


        [Test]
        public void WhenEmployeeLoginsAreNotEqual()
        {
            var employee1 = GetEmployee("Krzysiu");
            var employee2 = GetEmployee("Andrzej");

            Assert.AreEqual(employee1.Login, employee2.Login);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        } 
    }
}
