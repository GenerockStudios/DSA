using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DSA.Introduction.SimpleAlgorithm
{
    public class Fibonnacci
    {
        /// <summary>
        /// Thia method find the fibonacci series till the term less than 1000
        /// </summary>
        /// <param name="number"></param>
        public static void FindTheFibonacciSeriesTillTheTermLessThanNumber(int number = 1000)
        {
            Console.WriteLine($"Number = {number}");
            // Intialization
            int first_term = 0, second_term = 1, temp;

            // Displaying first term and second term
            Console.Write($"{first_term} {second_term}");

            while (second_term <= number)
            {
                temp = second_term;
                second_term = second_term + first_term;
                first_term = temp;
                Console.Write($" {second_term}");
            }
        }

    }
}
