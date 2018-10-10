//using System;

//namespace chapter06
//{
//    class Ch06Ex03
//    {
//        static int SumVals(params int[] val)
//        {
//            int sum = 0;
//            foreach (int num in val)
//                sum += num;
//            return sum;
//        }
//        static void DoubleValue(int[] myArray)
//        {
//            for (int i = 0; i < myArray.Length; ++i)
//                myArray[i] *= 2;
//        }
//        static void DoubleValueInt(ref int myVal)
//        {
//            myVal *= 2;
//        }
//        static int MaxValue(int[] myVal, out int maxIndex)
//        {
//            int maxValue = myVal[0];
//            maxIndex = 0;
//            for(int i=0;i<myVal.Length; ++i)
//            {
//                if(maxValue<myVal[i])
//                {
//                    maxValue = myVal[i];
//                    maxIndex = i;
//                }
//            }
//            return maxValue;
//        }
//        static void Main()
//        {
//            int[] val = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            //int sum = SumVals(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
//            //Console.WriteLine(sum);
//            DoubleValue(val);
//            for (int i = 0; i<val.Length; ++i)
//            {
//                Console.Write($"{val[i]} ");
//            }
//            Console.WriteLine();

//            int myVal = 12;
//            Console.WriteLine(myVal);
//            DoubleValueInt(ref myVal);
//            Console.WriteLine(myVal);

//            int maxIndex = 0;
//            int maxValue = MaxValue(val, out maxIndex);
//            Console.WriteLine($"max={maxValue}, index={maxIndex}");

//            string text = " ";
//            for(int i=0;i<10;++i)
//            {
//                text = "Line " + Convert.ToString(i);
//                Console.WriteLine(text);
//            }
//            Console.WriteLine(text);


//            Console.ReadKey();
//        }
//    }
//}