using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CubeNum(5));

            Console.ReadLine();
        }

        static int CubeNum(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
