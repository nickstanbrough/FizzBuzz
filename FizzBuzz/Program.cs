using FizzBuzz.LogicService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    static class Program
    {
        private static bool _keepAlive;
        private static int _validatedInput;
        private static bool _defineCustomVariables;
        private static int _valueFizz;
        private static int _valueBuzz;
        private static int _valuePop;

        static void Main(string[] args)
        {            
            LoadGame();
            
        }

        static void LoadGame()
        {
            _keepAlive = true;
            _defineCustomVariables = false;

            var gameService = new GameService();
            Console.WriteLine("Welcome to the Fizz Buzz game!");
                        
            while (_keepAlive)
            {
                DefineCustomVariables();

                Console.WriteLine("Enter a number: ");
                var input = Console.ReadLine();
                if (IsValidInt(input))
                {
                    gameService.StartGame(_validatedInput, _valueFizz, _valueBuzz, _valuePop);
                }
                else Console.WriteLine("Not a valid entry...");
                
                _keepAlive = PlayAgain();
            }

            Console.WriteLine("Thanks for playing! Press any key to exit.");
            Console.ReadLine();
        }

        private static bool IsValidInt(string input)
        {
            return Int32.TryParse(input, out _validatedInput);
        }


        private static void DefineCustomVariables()
        {
            while (true)
            {
                Console.WriteLine("Would you like to define your own variables? y/n");
                var input = Console.ReadLine().Trim().ToLower();
                if (input.Equals("y"))
                {
                    while (true)
                    {
                        Console.WriteLine("Enter Value for Fizz: ");
                        if (int.TryParse(Console.ReadLine(), out _valueFizz)) break;
                        Console.WriteLine("Invalid entry. Use an integer.");
                    }
                    while (true)
                    {
                        Console.WriteLine("Enter Value for Buzz: ");
                        if (int.TryParse(Console.ReadLine(), out _valueBuzz)) break;
                        Console.WriteLine("Invalid entry. Use an integer.");
                    }
                    while (true)
                    {
                        Console.WriteLine("Enter Value for Pop: ");
                        if (int.TryParse(Console.ReadLine(), out _valuePop)) break;
                        Console.WriteLine("Invalid entry. Use an integer.");
                    }

                    _defineCustomVariables = true;
                    return;
                }
                if (input.Equals("n"))
                {
                    Console.WriteLine("Defaulting to 3, 5 and 7");
                    _valueFizz = 3;
                    _valueBuzz = 5;
                    _valuePop = 7;
                    _defineCustomVariables = false;
                    return;
                }

                Console.WriteLine("not a valid entry...");
            }
        }
        private static bool PlayAgain()
        {   
            while(true)
            {
                Console.WriteLine("Would you like to play again? y/n");
                var input = Console.ReadLine().Trim().ToLower();
                if (input.Equals("y")) return true;
                if (input.Equals("n")) return false;

                Console.WriteLine("not a valid entry...");
            }
        }
    }
}
