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
            switch (operation)
            {
                case '+':
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case '-':
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case '*':
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case '/':
                    Console.WriteLine(firstNumber / secondNumber);
                    break;
                default:
                    Console.WriteLine("You input invalid operation");
                    break;
            }
        }
    }
}

