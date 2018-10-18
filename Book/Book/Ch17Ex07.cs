//using System;

//namespace Book
//{
//    interface IMyIfc<T>
//    {
//        T ReturnInt(T value);
//    }
//    class Simple: IMyIfc<int>, IMyIfc<string>
//    {
//        public int ReturnInt(int value)
//        {
//            return value;
//        }
//        public string ReturnInt(string value)
//        {
//            return value;
//        }
//    }
//    class Ch17Ex07
//    {
//        static void Main()
//        {
//            Simple s1 = new Simple();
//            Console.WriteLine("{0}", s1.ReturnInt(1));
//            Console.WriteLine("{0}", s1.ReturnInt("Hi there"));
//            Console.ReadKey();
//        }
//    }
//}