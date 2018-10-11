//using System;

//namespace Book
//{
//    delegate void PrintFunction();
//    class Test
//    {
//        public void Print1()
//        {
//            Console.WriteLine("Print1 -- instance");
//        }
//        public static void Print2()
//        {
//            Console.WriteLine("Print2 -- static");
//        }
//    }
//    class Ch13Ex02
//    {
//        static void Main()
//        {
//            Test t = new Test();
//            PrintFunction pf;
//            pf = new PrintFunction(t.Print1);
//            pf += Test.Print2;
//            pf += t.Print1;
//            pf += Test.Print2;

//            if (pf != null)
//                pf();
//            else
//                Console.WriteLine("delegate is None");

//            Console.ReadKey();
//        }
//    }
//}