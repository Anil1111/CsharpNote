//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Book
//{
//    class Ch19Ex02
//    {
//        static void Main()
//        {
//            int[] numbers = { 2, 5, 28, 31, 17, 16, 42 };
//            var numsQuery = from n in numbers where n < 20 select n;

//            var numsMethod = numbers.Where(x => x > 40);

//            int numsCount = (from n in numbers where n < 20 select n).Count();

//            foreach (int x in numsQuery)
//                Console.Write("{0}\t", x);
//            Console.WriteLine();

//            //if (numsMethod == null)
//            //    Console.WriteLine("null");
//            //else
//            //{
//                foreach (var x in numsMethod)
//                    Console.Write("{0}\t", x);
//                Console.WriteLine();
//            //}

//            Console.WriteLine(numsCount);

//            numbers[3] = 15;
//            numsMethod = numbers.Where(x => x < 20);
//            foreach (var x in numsMethod)
//                Console.Write("{0}\t", x);
//            Console.WriteLine();

//            Console.WriteLine("************************************");

//            string[] names = { "zhushuai", "johnson", "tomas", "jerry" };
//            var namesQuery = from na in names where na == "zhushuai" select na;
//            foreach (var name in namesQuery)
//                Console.WriteLine(name);

//            Console.WriteLine(string.Compare(names[0], names[2]));

//            Console.ReadKey();
//        }
//    }
//}