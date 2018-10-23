//using System;

//namespace Book
//{
//    static class ExtendHolder
//    {
//        public static void Print<T>(this Holder<T> h)
//        {
//            var vals = h.GetValues();
//            Console.WriteLine("{0},\t{1},\t{2}.", vals[0], vals[1], vals[2]);
//        }
//    }

//    class Holder<T>
//    {
//        T[] arr = new T[3];
//        public Holder(T a, T b, T c)
//        {
//            arr[0] = a;
//            arr[1] = b;
//            arr[2] = c;
//        }
//        public T[] GetValues()
//        {
//            return arr;
//        }
//    }

//    class Ch17Ex03
//    {
//        static void Main()
//        {
//            Holder<int> h1 = new Holder<int>(1, 2, 3);
//            Holder<string> h2 = new Holder<string>("zhu", "shuai", "johnson");

//            h1.Print<int>();
//            h2.Print();


//            Console.ReadKey();
//        }
//    }
//}