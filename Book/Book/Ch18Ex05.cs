//using System;
////using System.Collections.Generic;
//using System.Collections;

//namespace Book
//{
//    class Myclass
//    {
//        int[] myVal;
//        public Myclass(int[] val)
//        {
//            myVal = new int[val.Length];
//            for (int i = 0; i < val.Length; i++)
//                myVal[i] = val[i];
//        }
//        public IEnumerator NumbersInArray()
//        {
//            for (int i = 0; i < myVal.Length; i++)
//                yield return myVal[i];
//        }
//        public IEnumerator GetEnumerator()
//        {
//            return NumbersInArray();
//        }
//    }
//    class Ch18Ex05
//    {
//        static void Main()
//        {
//            int[] val = { 1, 2, 3, 4, 5 };
//            Myclass mc = new Myclass(val);
//            foreach (int i in mc)
//                Console.WriteLine(i);

//            Console.ReadKey();
//        }
//    }
//}