//using System;

//namespace Book
//{
//    class Ch15Ex02
//    {
//        static void Main()
//        {
//            MyClass[] mc = new MyClass[5];

            
//            for (int i = 0; i < 5; ++i)
//            {
//                mc[i] = new MyClass();
//            }
//            mc[0].Thevalue = 78;
//            mc[1].Thevalue = -2;
//            mc[2].Thevalue = 1;
//            mc[3].Thevalue = 23;
//            mc[4].Thevalue = 12;

//            for (int i = 0; i < 5; ++i)
//                Console.WriteLine(mc[i].Thevalue);

//            Console.WriteLine("********************************");

//            Array.Sort(mc);
//            for (int i = 0; i < 5; ++i)
//                Console.WriteLine(mc[i].Thevalue);
//            Console.ReadKey();
//        }
//    }
//    class MyClass:IComparable
//    {
//        public int Thevalue;
//        public int CompareTo(object obj)
//        {
//            MyClass mc = (MyClass)obj;
//            if (this.Thevalue < mc.Thevalue) return -1;
//            if (this.Thevalue > mc.Thevalue) return 1;
//            return 0;
//        }
//    }
//}