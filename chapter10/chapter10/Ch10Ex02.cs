//using System;

//namespace chapter10
//{

//    class Ch10Ex02
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Creating object myObj...");
//            MyClass myObj = new MyClass("My Object");
//            Console.WriteLine("myObj created.");
//            for (int i = -1; i <= 0; ++i)
//            {
//                try
//                {
//                    Console.WriteLine($"\nAttemped to assign {i} to myObj.val...");
//                    myObj.Val = i;
//                    Console.WriteLine($"Value {myObj.Val} assigned to myObj.Val.");
//                }
//                catch(Exception e)
//                {
//                    Console.WriteLine($"Exception {e.GetType().FullName} thrown");
//                    Console.WriteLine($"Message:\n\"{e.Message}\"");
//                }
//            }
//            Console.WriteLine("\nOutputting myObj.Tostring()...");
//            Console.WriteLine(myObj.ToString());
//            Console.WriteLine("myObj.ToString() output");

//            Console.WriteLine("\nMyDoubledIntProp = 5....");
//            Console.WriteLine($"Getting myDoubledIntProp of 5 is {myObj.MyDoubledIntProp}");

//            Console.ReadKey();
//        }
//    }
//}