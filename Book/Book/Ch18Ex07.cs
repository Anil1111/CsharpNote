//using System;
//using System.Collections.Generic;

//namespace Book
//{
//    class MyClass
//    {
//        int[] myVal;
//        public MyClass(int[] val)
//        {
//            myVal = new int[val.Length];
//            for (int i = 0; i < val.Length; i++)
//                myVal[i] = val[i];
//        }
//        public IEnumerable<int> Numbersenm()
//        {
//            for (int i = 0; i < (myVal.Length) / 2; i++)
//                yield return myVal[i];
//        }
        
//        public IEnumerable<int> Numbersenm1()
//        {
//            for (int i = (myVal.Length) / 2; i < myVal.Length; i++)
//                yield return myVal[i];
//        }

//        public IEnumerator<int> GetEnumerator()
//        {
//            IEnumerable<int> ienum = Numbersenm();
//            return ienum.GetEnumerator();
//        }

//    }
//    class Ch18Ex07
//    {
//        static void Main()
//        {
//            int[] val = { 1, 2, 3, 4, 5, 6 };
//            MyClass mc = new MyClass(val);
//            foreach (int item in mc)
//                Console.WriteLine(item);

//            foreach (int item in mc.Numbersenm1())
//                Console.WriteLine(item);

//            Console.ReadKey();
//        }
//    }
//}