
namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void AddingAndSubtractingNumbers()
        {
            var employee = new Employee("Krzysiu", "1234");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(2,statistics.Min);

        }
    }
}