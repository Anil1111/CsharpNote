using System;

namespace Ch03Ex01
{
    class Ch03Ex02
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}");
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " +
                $"{firstNumber + secondNumber}");
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine(Convert.ToChar(Console.Read()));
            Console.ReadKey();
        }
    }
}