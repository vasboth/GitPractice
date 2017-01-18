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
            //int defaultNumber = EnterANumber("Please enter a number between 0 - 1000:");

            //bool isInRange = IsNumberInRange(defaultNumber, 0, 1000);


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
