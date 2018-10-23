//using System;
//using System.Collections.Generic;

//namespace Book
//{
//    class MyClass
//    {
//        public IEnumerator<string> GetEnumerator()
//        {
//            return BlackAndWhite();
//        }
//        public IEnumerator<string> BlackAndWhite()
//        {
//            yield return "black";
//            yield return "gray";
//            yield return "while";
//        }
//    }
//    class Ch18Ex04
//    {
//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            foreach (string shade in mc)
//                Console.WriteLine(shade);

//            Console.ReadKey();
//        }
//    }
//}