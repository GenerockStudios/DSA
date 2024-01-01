using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DSA.Introduction.SimpleAlgorithm
{
    public class First_AdditionTwoNumberAndPrint
    {
        /// <summary>
        /// Best way to write function for addition, and return sum
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns></returns>
        public static int Sum(int a, int b)
            => a + b;

        /// <summary>
        /// This method use method Sum to print sum of 2 numbers
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        public static void PrintSum(int a, int b)
            => Console.WriteLine($"{a} + {b} = {Sum(a, b)}");

        /// <summary>
        /// This method without use method Sum to print sum of 2 numbers
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        public static void PrintSum2(int a, int b)
            => Console.WriteLine($"{a} + {b} = {a + b}");
    }
}
