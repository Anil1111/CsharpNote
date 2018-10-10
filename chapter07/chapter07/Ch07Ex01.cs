//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Diagnostics;
//using System.Threading.Tasks;

//namespace chapter07
//{
//    class Ch07Ex01
//    {
//        static void Main(string[] args)
//        {
//            int[] testArray = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };
//            int[] maxValIndeces;
//            int maxVal = Maxima(testArray, out maxValIndeces);
//            Console.WriteLine($"Maximum value {maxVal} found at element indices:");
//            foreach (int index in maxValIndeces)
//                Console.WriteLine(index);

//            Console.ReadKey();
//        }

//        static int Maxima(int[] integers, out int[] indices)
//        {
//            Debug.WriteLine("Maximum value seach started:");
//            indices = new int[1];
//            int maxVal = integers[0];
//            int count = 1;
//            Debug.WriteLine(string.Format($"Maximum value initialized to {maxVal}, at element index 0."));
//            for(int i=0; i< integers.Length; ++i)
//            {
//                Debug.WriteLine($"Now looking at element at index {i}");
//                if (integers[i]>maxVal)
//                {
//                    maxVal = integers[i];
//                    count = 1;
//                    indices = new int[1];
//                    indices[0] = i;
//                    Debug.WriteLine($"New maximum found. New value is {maxVal}, at element index {i}.");
//                }
//                else
//                {
//                    if (integers[i] == maxVal)
//                    {
//                        ++count;
//                        int[] oldIndeices = indices;
//                        indices = new int[count];
//                        oldIndeices.CopyTo(indices, 0);
//                        indices[count - 1] = i;
//                        Debug.WriteLine($"Duplicate Maximum found at element index {i}");
//                    }
//                }
//            }
//            Trace.WriteLine($"Maximum value {maxVal} found, with {count} occurences.");
//            Debug.WriteLine("Max Value  seach completed");
//            return maxVal;
//        }
//    }
//}
