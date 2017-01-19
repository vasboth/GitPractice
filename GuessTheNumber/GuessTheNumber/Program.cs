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
            // get the number first player thinks
            int theNumber = EnterANumber("Please enter a number between 0 - 1000:");
            CheckRanges(theNumber, 0, 1000);
            Console.ReadLine();
            Console.Clear();

            // guessing
            int guessedNumber = EnterANumber("Please guess a number between 0 - 1000:");
            while (!IsNumberInRange(guessedNumber, 0, 1000))
            {
                Console.WriteLine("Number is not between 0 - 1000, please enter another number.");
                guessedNumber = EnterANumber("Please enter a number between 0 - 1000:");
            }

            bool isEqual = NumberEquals(theNumber, guessedNumber);
            
            while (!isEqual)
            {
                string message = guessedNumber > theNumber ? "smaller" : "greater";
                Console.WriteLine("Incorrect. The number is {0}",message);
                guessedNumber = EnterANumber("Please guess another number between 0 - 1000:");
                isEqual = NumberEquals(theNumber, guessedNumber);
            }
            Console.WriteLine("Congtrats, you have guessed the correct number!");
            Console.ReadLine();

        }

        private static void CheckRanges(int number, int min, int max)
        {
            while (!IsNumberInRange(theNumber, 0, 1000))
            {
                Console.WriteLine("Number is not between 0 - 1000, please enter another number.");
                theNumber = EnterANumber("Please enter a number between 0 - 1000:");
            }

        }

        public static int EnterANumber(string message)
        {
            Console.WriteLine(message);
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            return enteredNumber;
        }

        public static bool NumberEquals(int x, int y)
        {
            return (x == y);
        }

    }
}
