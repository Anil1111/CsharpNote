//using System;

//namespace chapter07
//{
//    enum Orientation : byte
//    {
//        north=1,
//        south=2,
//        east=3,
//        west=4
//    }

//    class Ch07Ex03
//    {
//        static void Main(string[] args)
//        {
//            Orientation myOrentation = Orientation.south;
//            Console.WriteLine(myOrentation);

//            byte myByte = 5;
//            try
//            {
//                myOrentation = checked((Orientation)myByte);
//                if (myByte > 4)
//                    throw new ArgumentOutOfRangeException("myByte", myByte, "Value must be between 1 and 4");
//            }
//            catch(ArgumentOutOfRangeException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            Console.WriteLine(myOrentation);

//            Console.ReadKey();
//        }
//    }
//}