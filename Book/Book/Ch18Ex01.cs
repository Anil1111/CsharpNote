//using System;
//using System.Collections;

//namespace Book
//{
//    class Ch18Ex01
//    {
//        static void Main() 
//        {
//            int[] myArr = new int[] { 10, 11, 12, 13 };
//            IEnumerator ie = myArr.GetEnumerator();
            
//            while(ie.MoveNext())
//            {
//                int item = (int)(ie.Current);
//                Console.WriteLine("{0}", item);
//            }

//            Console.ReadKey();
//        }
//    }
//}