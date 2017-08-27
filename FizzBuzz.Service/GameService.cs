using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FizzBuzz.LogicService
{
    public class GameService
    {

        public void StartGame(int input, int fizzVal, int buzzVal, int popVal)
        {
            bool divisibleByFizz = IsMultiple(input, fizzVal);
            bool divisibleByBuzz = IsMultiple(input, buzzVal);
            bool divisibleByPop = IsMultiple(input, popVal);

            if (divisibleByFizz && divisibleByBuzz && divisibleByPop)
            {
                PrintResult("Fizz Buzz Pop");
                return;
            }
            if (divisibleByFizz && divisibleByBuzz)
            {
                PrintResult("Fizz Buzz");
                return;
            }
            if (divisibleByFizz && divisibleByPop)
            {
                PrintResult("Fizz Pop");
                return;
            }
            if (divisibleByBuzz && divisibleByPop)
            {
                PrintResult("Buzz Pop");
                return;
            }
            if (divisibleByFizz)
            {
                PrintResult("Fizz");
                return;
            }
            if(divisibleByBuzz)
            {
                PrintResult("Buzz");
                return;
            }
            if (divisibleByPop)
            {
                PrintResult("Pop");
                return;
            }
            
            PrintResult(input);

        }

        private bool IsMultiple(int value, int multipleOfNum)
        {
            return value % multipleOfNum == 0;
        }

        private void PrintResult(object value)
        {
            Console.WriteLine($"Game Result: {value}");
        }

        


    }
}
