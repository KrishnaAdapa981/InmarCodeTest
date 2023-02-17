using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            var result = String.Empty;

            for(int i = s.Length-1; i>=0; i--)
            {
                result += s[i];
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
