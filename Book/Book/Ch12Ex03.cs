//using System;

//namespace Book
//{
//    class Ch12Ex03
//    {
//        static void Main()
//        {
//            int[][] Jarray = new int[3][];
//            Jarray[0] = new int[2] { 1, 2 };
//            Jarray[1] = new int[3] { 1, 2, 3 };
//            Jarray[2] = new int[4] { 1, 2, 3, 4 };

//            Console.WriteLine(Jarray[0].GetLength(0));

//            int[] arr = new int[] { 15, 20, 5, 25, 10 };
//            Print(arr);
//            Array.Sort(arr);
//            Print(arr);

//            Array.Reverse(arr);
//            Print(arr);

//            Console.WriteLine("*************************");

//            int[] cArr = (int[])arr.Clone();
//            Print(cArr);

//            Console.WriteLine("*************************");

//            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
//            int[] arr2 = new int[] { 6, 7, 8, 9, 10 };
//            int[] arr3 = new int[] { 2, 4, 6, 8, 10 };

//            int[][] arr_m = new int[][] { arr1, arr2, arr3 };
//            int[][] carr_m = (int[][])arr_m.Clone();
//            foreach(int[] arrf in carr_m)
//            {
//                foreach (int i in arrf)
//                    Console.Write($"{i}     ");
//                Console.WriteLine();
//            }
//            carr_m[1][1] += 10;

//            Console.WriteLine("*************************");

//            foreach (int[] arrf in carr_m)
//            {
//                foreach (int i in arrf)
//                    Console.Write($"{i}     ");
//                Console.WriteLine();
//            }

//            Console.WriteLine("*************************");
//            foreach (int[] arrf in arr_m)
//            {
//                foreach (int i in arrf)
//                    Console.Write($"{i}     ");
//                Console.WriteLine();
//            }
//            Console.ReadKey();
//        }
//        static void Print(int[] arr)
//        {
//            foreach (int i in arr)
//                Console.Write($"{i}     ");
//            Console.WriteLine();
//        }
//    }
//}