//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Console;

//namespace chapter04
//{
//    class Ch04Ex01
//    {
//        static void Main(string[] args)
//        {
//            bool boolen = false;
//            boolen = 9 < 12;
//            int a1 = 0b0101;
//            int a2 = 0b1010;
//            a1 ^= a2;
//            Console.WriteLine(a1);

//            Console.WriteLine(boolen);

//            WriteLine("Enter a integer:");
//            int myInt = Convert.ToInt32(ReadLine());
//            string resultString = (myInt < 10) ? "Less Than 10" : "Greater Than or Equal to 10";
//            int result = myInt < 19 ? 12 : 13;
//            WriteLine(result);
//            WriteLine(resultString);
//            bool isLessThan10 = myInt < 10;
//            bool isBetween0And5 = (myInt >= 0) && (myInt <=5);
//            WriteLine(myInt.GetType());
//            WriteLine($"Integer is less than 10 ? {isLessThan10}");
//            WriteLine($"Integer is between 0 and 5 ? {isBetween0And5}");
//            WriteLine($"Exactly one of the above is true ?" + $"{isLessThan10 ^ isBetween0And5}");

            

//            Console.ReadKey();
//        }
//    }
//}
