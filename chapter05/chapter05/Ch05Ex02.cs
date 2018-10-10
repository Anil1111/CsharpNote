//using static System.Console;
//using System;

//namespace chapter05
//{
//    enum orientation:byte
//    {
//        north = 1,
//        south = 2,
//        east = 3,
//        west = 4
//    }
//    class Ch05Ex02
//    {
//        static void Main(string[] args)
//        {
//            byte directionByte;
//            string directionString;
//            orientation myDirection = orientation.north;
//            WriteLine($"mydirection = {myDirection}");
//            directionByte = (byte)myDirection;
//            directionString = Convert.ToString(myDirection);
//            WriteLine($"byte equivalent = {directionByte}");
//            WriteLine($"string equivalent = {directionString}");

//            byte myByte = 2;
//            orientation anotherDestination = (orientation)myByte;
//            WriteLine(anotherDestination);

//            ReadKey();
//        }
//    }
//}