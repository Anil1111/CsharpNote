//using System;

//namespace Book
//{
//    interface IGetData
//    {
//        int GetData();
//    }
//    interface ISetData
//    {
//        void SetData(int x);
//    }
//    class MyClass:IGetData, ISetData
//    {
//        public int mem;
//        public int GetData()
//        {
//            return mem;
//        }
//        public void SetData(int x)
//        {
//            mem = x;
//        }
//    }
//    // 重复接口的单一实现
//    interface IIfc1
//    {
//        void PrintOut(string s);
//    }

//    interface IIfc2
//    {
//        void PrintOut(string s);
//    }

//    class MyClass2:IIfc1, IIfc2
//    {
//        public void PrintOut(string s)
//        {
//            Console.WriteLine("Calling through {0}", s);
//        }
//    }

//    class Ch15Ex05
//    {
//        static void Main()
//        {
//            MyClass mc =  new MyClass();
//            mc.SetData(12);
//            Console.WriteLine(mc.GetData());

//            IGetData ig = mc as IGetData;
//            Console.WriteLine(ig.GetData());

//            MyClass2 mc2 = new MyClass2();
//            mc2.PrintOut("main");
//            IIfc1 fc1 = mc2 as IIfc1;
//            fc1.PrintOut("submain");
//            IIfc2 fc2 = mc2 as IIfc2;
//            fc2.PrintOut("submain2");

//            Console.ReadKey();
//        }
//    }
//}