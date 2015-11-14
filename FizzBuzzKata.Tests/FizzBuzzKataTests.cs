using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzKataTests
    {
        private Game game;
        private string output;

        [SetUp]
        public void CreateGame()
        {
            game = new Game();
            game.Solve();
        }

        [TestCase(0, null)]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(23, "Fizz")]
        [TestCase(35, "Fizz")]
        [TestCase(53, "Fizz")]
        [TestCase(58, "Buzz")]
        [TestCase(101, null)]
        public void TestGame(int input, string result)
        {
            output = game.OutputForNumber(input);
            Assert.That(output, Is.EqualTo(result));
        }
    }
}
