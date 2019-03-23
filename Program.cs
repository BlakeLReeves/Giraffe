using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are male or tall.");
            } else if (isMale && !isTall) {
                Console.WriteLine("You are male and not tall.");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not a male but are tall.");
            } else
            {
                Console.WriteLine("You are not male and not tall.");
            }

            Console.ReadLine();
        }
    }
}
