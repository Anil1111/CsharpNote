//using System;
//using static System.Console;
//using static System.Convert;

//namespace chapter04
//{
//    class Ch04Ex04
//    {
//        static void Main(string[] args)
//        {
//            double balance, interestRate, targetBalance;
//            WriteLine("What is your current balance:");
//            balance = ToDouble(ReadLine());
//            WriteLine("What is your current annual interest rate (in %)?");
//            interestRate = 1 + ToDouble(ReadLine()) / 100;
//            WriteLine("What balance would you like to have");
//            targetBalance = ToDouble(ReadLine());
//            int totalYears = 0;
//            // do
//            while (totalYears < targetBalance)
//            {
//                balance *= interestRate;
//                ++totalYears;
//            }
//            // while (totalYears < targetBalance);
//            WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} you will have a balance of {balance}");
//            ReadKey();
//        }
//    }
//}