using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Kyle";
            friends[1] = "David";

            luckNumbers[1] = 900;

            Console.WriteLine( friends[1] );

            Console.ReadLine();
        }
    }
}
