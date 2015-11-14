using System.CodeDom;

namespace FizzBuzzKata
{
    public class Game
    {
        private int range;
        private string[] result;

        public Game()
        {
            range = 100;
            result = new string[range];
        }

        public void Solve()
        {
            var number = 0;
            for (int index = 0; index < range; index++)
            {
                number = index + 1;
                if (IsMultipleOfThreeAndFive(number))
                {
                    result[index] = "FizzBuzz";
                }
                else if (IsMultipleOfThree(number) || ContainsThree(number))
                {
                    result[index] = "Fizz";
                }
                else if (IsMultipleOfFive(number) || ContainsFive(number))
                {
                    result[index] = "Buzz";
                }
                else
                {
                    result[index] = number.ToString();
                }
            }
        }

        public string OutputForNumber(int number)
        {
            if (number < 1 || number > range)
            {
                return null;
            }
            else
            {
                return result[number - 1];
            }
        }

        private bool IsMultipleOfThree(int number)
        {
            return number%3 == 0;
        }

        private bool IsMultipleOfFive(int number)
        {
            return number%5 == 0;
        }

        private bool IsMultipleOfThreeAndFive(int number)
        {
            return IsMultipleOfThree(number) && IsMultipleOfFive(number);
        }

        private bool ContainsThree(int number)
        {
            return IsValueInNumber(number, 3);                
        }

        private bool ContainsFive(int number)
        {
            return IsValueInNumber(number, 5);
        }

        private bool IsValueInNumber(int number, int value)
        {
            while (number != 0)
            {
                int digit = number%10;
                if (digit == value)
                {
                    return true;
                }
                number = number/10;
            }
            return false;
        }
    }
}
