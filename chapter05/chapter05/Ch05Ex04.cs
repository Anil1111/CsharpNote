//using System;

//namespace chapter05
//{
//    class Ch05Ex04
//    {
//        static void Main()
//        {
//            // 一维数组实例
//            const int arraySize = 5;
//            // int[] myArray = new int[arraySize] { 1, 2, 3, 4, 5 };
//            // int[] myArray = { 1, 2, 3, 4, 5 };
//            int[] myArray = new int[arraySize];
//            foreach (int num in myArray)
//            {
//                Console.Write($"{num} ");
//            }
//            Console.WriteLine();

//            Console.WriteLine("=======================================");

//            // 多维数组实例
//            // int[,] myArray2 = { { 1, 2, 3, 4 }, { 2, 3, 5, 6 }, { 3, 4, 5, 6 } };
//            int[,] myArray2 = new int[3,4]{ { 1, 2, 3, 4 }, { 2, 3, 5, 6 }, { 3, 4, 5, 6 } };
//            // int[,] myArray2 = new int[3,4];
//            int count = 0;
//            foreach (int num in myArray2)
//            {
//                Console.Write($"{num} ");
//                ++count;
//                if(count == 4)
//                {
//                    count = 0;
//                    Console.WriteLine();
//                }
//            }
                    

//            // 锯齿数组实例
//            int[][] jaggerArray;
//            jaggerArray = new int[2][];
//            jaggerArray[0] = new int[3] { 1, 2, 3 };
//            jaggerArray[1] = new int[1] { 1 };
//            foreach (int[] array in jaggerArray)
//            {
//                foreach (int num in array)
//                    Console.Write($"{num} ");
//                Console.WriteLine();
//            }

//            // int[][] newJaggerArray = new int[4][] { new int[1] { 1 }, new int[2] { 1, 2 }, new int[3] { 1, 2, 3 }, new int[4] { 1, 2, 3, 4 } };
//            int[][] newJaggerArray = { new int[1] { 1 }, new int[2] { 1, 2 }, new int[3] { 1, 2, 3 }, new int[4] { 1, 2, 3, 4 } };
//            foreach(int[] array in newJaggerArray)
//            {
//                foreach (int num in array)
//                    Console.Write($"{num} ");
//                 Console.WriteLine();
//            }

//            Console.ReadKey();
//        }
//    }
//}