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
            int defaultNumber = ThinkANumber();
            Console.ReadLine();
        }

        public static int ThinkANumber()
        {
            Console.WriteLine("Please enter a number between 0-1000:");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            return enteredNumber;
        }

        public static bool IsNumberInRange(int number, int min, int max)
        {
            return (number >= min) && (number <= max);
        }
    }
}
