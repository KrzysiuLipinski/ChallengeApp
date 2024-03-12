
namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void AddingAndSubtractingNumbers()
        {
            var user = new Employee("Krzysiu", "1234");
            user.AddScore(6);
            user.AddScore(10);
            user.AddScore(20);
            user.AddScore(-2);

            var result = user.Result;

            Assert.AreEqual(34, result);

        }
    }
}