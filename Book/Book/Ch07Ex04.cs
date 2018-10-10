//using System;

//namespace Book
//{
//    sealed class MyClass
//    {
//        private double D1, D2, D3;
//        public MyClass(double d1,double d2,double d3)
//        {
//            D1 = d1;
//            D2 = d2;
//            D3 = d3;
//        }
//        public double Sum()
//        {
//            return D1 + D2 + D3;
//        }
//    }

//    static class ExtendMyClass
//    {
//        public static double Average(this MyClass mc)
//        {
//            return mc.Sum() / 3;
//        }
//    }

//    class Ch07Ex04
//    {
//        static void Main(string[] args)
//        {
//            MyClass mc = new MyClass(1, 2, 3);
//            Console.WriteLine(mc.Average());

//            MyClass mc2 = new MyClass(4, 5, 6);

//            Console.ReadKey();
//        }
//    }
//}