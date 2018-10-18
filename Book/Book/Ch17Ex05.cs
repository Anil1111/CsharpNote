//using System;

//namespace Book
//{
//    delegate R algro<R, T>(T a1, T a2);
//    class MyClass
//    {
//        public int add_2(int a1, int a2)
//        {
//            return a1 + a2;
//        }
//        public int sub_2(int a1, int a2)
//        {
//            return a1 - a2;
//        }
        
//    }
//    class Ch17Ex05
//    {
//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            algro<int, int> a1 = new algro<int, int>(mc.add_2);
//            Console.WriteLine(a1(1, 2));
//            a1 += mc.sub_2;
//            Console.WriteLine(a1(1, 2));
//            Console.ReadKey();
//        }
//    }
//}