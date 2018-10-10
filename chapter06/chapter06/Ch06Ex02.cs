//using System;

//namespace chapter06
//{
//    class Ch06Ex02
//    {
//        static int MaxValue(int[] myArray)
//        {
//            int maxValue = myArray[0];
//            for (int i=0; i<myArray.Length; ++i)
//            {
//                if (maxValue < myArray[i])
//                    maxValue = myArray[i];
//            }
//            return maxValue;
//        }
//        static void Main()
//        {
//            int[] myArray = new int[10] { 1, 2, 3, 1, 34, 6, 7, 8, 9, 10 };
//            int maxValue = MaxValue(myArray);
//            Console.WriteLine($"The max value of array is {maxValue}.");

//            Console.ReadKey();
//        }
//    }
//}