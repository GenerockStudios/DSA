using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DSA.Introduction.SimpleAlgorithm
{
    public class Factorial
    {
        /// <summary>
        /// This is recursive method who return factorial
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int RecursiveFactorial(int number)
        {
            if (number == 0)
                return 1;
            return number * RecursiveFactorial(number - 1);
        }

        /// <summary>
        /// This method print recursive factorial
        /// </summary>
        /// <param name="number">number you wants do factorial</param>
        public static void PrintRecursiveFactorial(int number)
            => Console.WriteLine($" {number}! = {RecursiveFactorial(number)} ");

        /// <summary>
        /// This is a non recursive method who return factorial
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int NonRecursiveFactorial(int number)
        {
            if (number == 0)
                return 0;

            int result = 1;

            for (int i = number; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// This method print recursive factorial
        /// </summary>
        /// <param name="number">number you wants do factorial</param>
        public static void PrintNonRecursiveFactorial(int number)
            => Console.WriteLine($" {number}! = {NonRecursiveFactorial(number)} ");

    }
}
