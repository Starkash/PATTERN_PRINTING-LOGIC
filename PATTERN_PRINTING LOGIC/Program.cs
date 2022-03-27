using System;

namespace PATTERN_PRINTING_LOGIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No. of Layer of pyramid:");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >=0; i--)  ///// REVERSE PYRAMID 
            {
                for (int j = 1; j <= n - i; j++)

                    Console.Write(" ");

                for (int k = 1; k <= 2 * i + 1; k++)

                    Console.Write("*");
                Console.WriteLine();

                //    for (int i = 0; i <= n; i++) //////// PYRAMID
                //{
                //    for (int j = 1; j <= n - i; j++)

                //        Console.Write(" ");

                //        for (int k = 1; k <= 2 * i + 1; k++)

                //            Console.Write("*");
                //            Console.WriteLine();

                //}
            }
        }
    }
}
