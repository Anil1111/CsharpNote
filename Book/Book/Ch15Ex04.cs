//using System;

//namespace Book
//{
//    interface IIfc1
//    {
//        void PrintOut(string s);
//    }

//    class MyClass:IIfc1
//    {
//        public void PrintOut(string s)
//        {
//            Console.WriteLine("Calling through: {0}", s);
//        }
//    }
//    class Ch15Ex03
//    {
//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            Print(mc, "zhushuai");
//            //IIfc1 Iint = (IIfc1)mc;
//            IIfc1 Iint = mc as IIfc1;
//            Iint.PrintOut("object");

//            Console.ReadKey();
//        }
//        static void Print(IIfc1 i1, string s)
//        {
//            i1.PrintOut(s);
//        }
//    }
//}