//using System;
//using System.Collections.Generic;

//namespace Book
//{
//    class MyClass
//    {
//        public IEnumerable<string> BlackAndWhite()
//        {
//            yield return "black";
//            yield return "white";
//            yield return "gray";
//        }
//        public IEnumerator<string> GetEnumerator()
//        {
//            IEnumerable<string> iemu = BlackAndWhite();
//            return iemu.GetEnumerator();
//        }
//    }

//    class Ch18Ex06
//    {
//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            foreach (string item in mc)
//                Console.WriteLine(item);

//            foreach (string item in mc.BlackAndWhite()) //可枚举类型中包含GetEnumerator()方法；
//                Console.WriteLine(item);

//            Console.ReadKey();
//        }
//    }
//}