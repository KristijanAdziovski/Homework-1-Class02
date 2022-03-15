using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            string numOne = Console.ReadLine();
            Console.WriteLine("Input operator");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input second number");
            string numThree = Console.ReadLine();
            decimal firstNumber = decimal.Parse(numOne);
            decimal secondNumber = decimal.Parse(numThree);
            if (operation == '+')
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
            else if (operation == '-')
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            else if (operation == '*')
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
            else if (operation == '/')
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            else { Console.WriteLine("You input invalid operator"); }
        }
    }
}