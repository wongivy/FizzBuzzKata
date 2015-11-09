using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class Game
    {
        private int range;

        public Game()
        {
            range = 0;
        }

        public void SetRange(int value)
        {
            range = value;
        }

        public string Print()
        {
            var result = "";
            for (int number = 1; number <= range; number++)
            {
                if (isDivisibleByThree(number))
                {
                    result += "Fizz, ";
                }
                else
                {
                    result += number + ", ";
                }
            }
            return result;
        }

        private bool isDivisibleByThree(int value)
        {
            return value%3 == 0;
        }
    }
}
