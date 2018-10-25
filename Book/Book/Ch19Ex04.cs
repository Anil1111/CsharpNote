//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Book
//{
//    class Ch19Ex04
//    {
//        static void Main()
//        {
//            int[] GroupA = new int[] { 3, 4, 5, 6 };
//            int[] GroupB = new int[] { 6, 7, 8, 9 };

//            var someInts = from a in GroupA
//                           from b in GroupB
//                           where a >= 4 && b <= 8
//                           let sum = a + b
//                           where sum == 12
//                           select new { a, b, sum };

//            foreach (var item in someInts)
//                Console.WriteLine(item);

//            var student = new { name = "alice", age = 19, major = "japanese" };
//            Console.WriteLine(student);

//            Console.ReadKey();
//        }
//    }
//}