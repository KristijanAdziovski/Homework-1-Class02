using System;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            string numOne = Console.ReadLine();
            Console.WriteLine("Input second number");
            string numTwo = Console.ReadLine();
            Console.WriteLine("Input third number");
            string numThree = Console.ReadLine();
            Console.WriteLine("Input fourth number");
            string numFour = Console.ReadLine();
            decimal intNumOne = decimal.Parse(numOne);
            decimal intNumTwo = decimal.Parse(numTwo);
            decimal intNumThree = decimal.Parse(numThree);
            decimal intNumFour = decimal.Parse(numFour);
            decimal average = (intNumOne + intNumTwo + intNumThree + intNumFour) / 4;
            if (intNumOne == 0 && intNumTwo == 0 && intNumThree == 0 && intNumFour == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine(average);
            }


        }
    }
}