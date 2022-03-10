using System;

namespace Homework_1_Class02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Input second number");
            string secondNumber = Console.ReadLine();
            int numberOne=int.Parse(firstNumber);
            int numberTwo=int.Parse(secondNumber);
            int swap;
            swap = numberOne;
            numberOne = numberTwo;
            numberTwo = swap;
            Console.WriteLine($"Prviot broj e {numberOne} vtorniot broj e {swap}");

        }
    }
}
