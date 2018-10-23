//using System;

//namespace Book
//{
//    class Simple
//    {
//        static public void ReverseAndPrint<T>(T [] arr)
//        {
//            Array.Reverse(arr);
//            foreach (T tmp in arr)
//                Console.Write("{0}  ", tmp);
//            Console.WriteLine();
//        }
//    }
//    class Ch17Ex02
//    {
//        static void Main()
//        {
//            int[] arr_i = new int[] { 3, 5, 7, 9, 11 };
//            string[] arr_s = new string[] { "first", "second", "third" };
//            double[] arr_d = new double[] { 3.567, 7.891, 2.345 };
//            Simple.ReverseAndPrint<int>(arr_i);
//            Simple.ReverseAndPrint(arr_s);
//            Simple.ReverseAndPrint(arr_d);

//            Console.ReadKey();
//        }
//    }
//}