using System;

namespace OperatorExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Create integer variables
            int a = 17;
            int b = 4;

            //Create 2 more integer variables
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
                Console.WriteLine($"{a}/{b} is {b} remainder {remainder}");





        }
    }
}
