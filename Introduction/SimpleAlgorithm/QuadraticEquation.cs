using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DSA.Introduction.SimpleAlgorithm
{
    /// <summary>
    /// This method contains method to resolve quadratic equation
    /// </summary>
    public class QuadraticEquation
    {
        /// <summary>
        /// Thsi method find roots of a quadratic Equation ax^2 + bx + c = 0
        /// </summary>
        /// <param name="a">value of A</param>
        /// <param name="b">value of B</param>
        /// <param name="c">value of C</param>
        public static void FindRootsOfAQuadraticEquation(int a, int b, int c)
        {
            float delta, x1, x2, x, imaginarypart = 0;

            // calculate discriminant
            delta = (float)Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                x1 = (-1 * b + (float)Math.Sqrt(delta)) / 2 * a;
                x2 = (-1 * b - (float)Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine($" delta = {Math.Round(delta)} and delta > 0. \n {a}x^2 + {b}x + {c} = 0 \n Solution x1 = {x1}, x2 = {x2}.");
            }
            else if (delta == 0)
            {
                x = -1 * b / 2 * a;
                imaginarypart = (float)(Math.Sqrt(-1 * delta) / 2 * a);
                Console.WriteLine($"delta = 0.\n {a}x^2 + {b}x + {c} = 0 \n  Solution x or realpart = {x}, imaginary part = {imaginarypart}.");
            }
            else
                Console.WriteLine($"delta = {Math.Round(delta)} < 0.\n {a}x^2 + {b}x + {c} = 0 \n  has no solution.");
        }
    }
}
