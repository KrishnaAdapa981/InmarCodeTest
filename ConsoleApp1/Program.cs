using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }

                if(i%3== 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
            }
        }
    }
}
