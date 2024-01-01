using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DSA.Introduction.SimpleAlgorithm
{
    public class PrimeNumber
    {
        /// <summary>
        /// This method use recursion for determinate if number is prime True : False 
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <param name="i">Cursor or divisor, is optional</param>
        /// <returns></returns>
        public static bool IsPrime(int number, int i = 2)
        {
            // 2 is automatically prime return true, or false for number under 2
            if (number <= 2)
                return number == 2 ? true : false;
            // if rest of division is equals 0 this number is not prime
            if (number % i == 0)
                return false;
            // if i times i is over number this number is prime eg 7 , 7 * 7 = 49 
            if (i * i > number)
                return true;

            // check next divisor
            return IsPrime(number, i + 1);
        }

        /// <summary>
        /// This method is recursive version for check if number is prime
        /// </summary>
        /// <param name="number">Number to check</param>
        public static void RecursiveIsPrimeNumber(int number)
        {
            Console.WriteLine("--- Recursive version ---");
            if (IsPrime(number))
                Console.WriteLine($"{number} is prime");
            else
                Console.WriteLine($"{number} is not prime");
        }


        /// <summary>
        /// This method is non recursive version for check if number is prime
        /// </summary>
        /// <param name="number">Number to check</param>
        public static void NonRecursiveIsPrimeNumber(int number)
        {
            Console.WriteLine("--- non-recursive version ---");

            if (number <= 1)
            {
                Console.WriteLine($"{number} is not prime.");
                return;
            }
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                {
                    Console.WriteLine($"{number} is not prime.");
                    return;
                }

            Console.WriteLine($"{number} is prime.");

        }
    }
}
