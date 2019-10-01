using System;

namespace arräer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] siffror = new int [5];

            for (int i = 0; i < siffror.GetLength(0); i++)
            {
                Console.WriteLine("Enter a number");
                string p = Console.ReadLine();
                int.TryParse(p, out int a);
                siffror[i] = a;

            }
            Console.WriteLine("Your array in reverse");
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(siffror[i]);
            }
        }
    }
}
