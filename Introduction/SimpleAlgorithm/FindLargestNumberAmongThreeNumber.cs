using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DSA.Introduction.SimpleAlgorithm
{
    public class FindLargestNumberAmongThreeNumber
    {
        /// <summary>
        /// This method find the Largest Number among three number and display it
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        public static void PrintLargestNumberAmongThree(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
                Console.WriteLine($"The largest number  {num1}, {num2}, {num3} is {num1}");
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine($"The largest number among {num1}, {num2}, {num3} is {num2}");
            else
                Console.WriteLine($"The largest number among {num1}, {num2}, {num3} is {num3}");
        }
    }
}
