using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzKataTests
    {
        private Game game;
        private string result;

        [TestFixtureSetUp]
        public void CreateGame()
        {
            game = new Game();
            result = "";
        }

        [Test]
        public void ShouldReturnOne()
        {
            game.SetRange(1);
            result = game.Print();
            Assert.That(result, Is.EqualTo("1, "));
        }

        [Test]
        public void ShouldReturnThreeAsFizz()
        {
            game.SetRange(3);
            result = game.Print();
            Assert.That(result, Is.EqualTo("1, 2, Fizz, "));
        }

        [Test]
        public void ShouldReturnFiveAsBuzz()
        {
            game.SetRange(5);
            result = game.Print();
            Assert.That(result, Is.EqualTo("1, 2, Fizz, 4, Buzz, "));
        }

        //[Test]
        public void ShouldReturnFifteenAsFizzBuzz()
        {
            game.SetRange(15);
            result = game.Print();

        }
    }
}
