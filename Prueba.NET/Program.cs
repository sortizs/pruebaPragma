using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.NET
{
    class Program
    {
        /// <summary>
        /// Use the main method to make debug
        /// </summary>
        static void Main(string[] args)
        {
            /// First task
            Console.WriteLine("First task");
            FirstTask ft = new FirstTask();
            /// Test array
            int[] T = { 1, 1, 2, 2, 3, 3 };
            Console.WriteLine(string.Format("The sister has {0} different kinds of candies", ft.Solution(T)));

            /// Second task
            Console.WriteLine("\nSecond task");
            SecondTask st = new SecondTask();
            /// Test array
            int[] ranks = { };
            Console.WriteLine(string.Format("{0} soldiers report to a superior", st.Solution(ranks)));

            /// Third task
            Console.WriteLine("\nThird task");
            ThirdTask tt = new ThirdTask();
            /// Test array
            int[] A = { 1, 1, 0, 1, 0, 0 };
            Console.WriteLine(string.Format("The greatest possible adjacency is of {0} pairs", tt.Solution(A)));
            /// 
            Console.Write("\nPress enter to exit");
            Console.ReadKey();
        }
    }
}
