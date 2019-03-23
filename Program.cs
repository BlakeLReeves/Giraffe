using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            SayHi("Blake", 23);
            SayHi("David", 29);
            SayHi("Kyle", 22);
             
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

    }
}
