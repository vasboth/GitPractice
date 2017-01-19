using System;

namespace GuessTheNumber
{
    public class Program
    {
        public static string EnterText = "Please enter a number between {0} - {1}:";
        public static string GuessText = "Please guess a number between {0} - {1}:";
        public static string WrongInputText = "Number is not between {0} - {1}, please enter another number.";
        
        static void Main()
        {
            // Test comment
            int min = 0;
            int max = 1000;
            
            // get the number first player thinks
            int theNumber = GetTheNumber(min, max);
            Console.ReadLine();
            Console.Clear();

            // guessing
            int guessResult = Guess(min, max, theNumber);
            while (guessResult != 0)
            {
                string message = guessResult < 0 ? "smaller" : "greater";
                Console.WriteLine("Incorrect. The number is {0}", message);

                guessResult = Guess(min, max, theNumber);
            }

            // succeed
            Console.WriteLine("Congtrats, you have guessed the correct number!");
            Console.ReadLine();
        }

        private static int GetTheNumber(int min, int max)
        {
            int theNumber = EnterANumber(String.Format(EnterText, min, max));
            while (!IsNumberInRange(theNumber, min, max))
            {
                Console.WriteLine(WrongInputText, min, max);
                theNumber = EnterANumber(String.Format(EnterText, min, max));
            }
            return theNumber;
        }

        private static int Guess(int min, int max, int theNumber)
        {
            int guess = EnterANumber(String.Format(GuessText, min, max));
            while (!IsNumberInRange(guess, min, max))
            {
                Console.WriteLine(WrongInputText, min, max);
                guess = EnterANumber(String.Format(GuessText, min, max));
            }
            return theNumber.CompareTo(guess);
        }
        
        public static bool IsNumberInRange(int number, int min, int max)
        {
            return (number >= min) && (number <= max);
        }

        public static int EnterANumber(string message)
        {
            Console.WriteLine(message);
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            return enteredNumber;
        }

    }
}
