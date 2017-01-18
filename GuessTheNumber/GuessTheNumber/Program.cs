using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int defaultNumber = EnterANumber("Please enter a number between 0 - 1000:");

            bool isInRange = IsNumberInRange(defaultNumber, 0, 1000);
            while (!isInRange)
            {
                Console.WriteLine("Number is not between 0 - 1000, please enter another number.");
                defaultNumber = EnterANumber("Please enter a number between 0 - 1000:");
                isInRange = IsNumberInRange(defaultNumber, 0, 1000);
            }

            Console.ReadLine();
            Console.Clear();

            int guessedNumber = EnterANumber("Please guess a number between 0 - 1000:");

            isInRange = IsNumberInRange(guessedNumber, 0, 1000);
            while (!isInRange)
            {
                Console.WriteLine("Number is not between 0 - 1000, please enter another number.");
                guessedNumber = EnterANumber("Please enter a number between 0 - 1000:");
                isInRange = IsNumberInRange(guessedNumber, 0, 1000);
            }

            bool isEqual = NumberEquals(defaultNumber, guessedNumber);
            
            while (!isEqual)
            {
                string message = guessedNumber > defaultNumber ? "smaller" : "greater";
                Console.WriteLine("Incorrect. The number is {0}",message);
                guessedNumber = EnterANumber("Please guess another number between 0 - 1000:");
                isEqual = NumberEquals(defaultNumber, guessedNumber);
            }
            Console.WriteLine("Congtrats, you have guessed the correct number!");
            Console.ReadLine();

        }

        public static int EnterANumber(string message)
        {
            Console.WriteLine(message);
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            return enteredNumber;
        }

        public static bool IsNumberInRange(int number, int min, int max)
        {
            return (number >= min) && (number <= max);
        }

        public static bool NumberEquals(int x, int y)
        {
            return (x == y);
        }

    }
}
