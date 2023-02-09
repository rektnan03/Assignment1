using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 300; i++)
            {
                GetOddNumberDivisiblebyFive(i);
            }
        }

        private static void GetOddNumberDivisiblebyFive(int i)
        {
            if ((i % 2) != 0 && (i % 5) == 0)
            {

                Console.WriteLine(i);
            }
        }
    }
}