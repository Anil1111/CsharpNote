//using System;

//namespace Book
//{
//    delegate int MyDel();
//    delegate int MyDel2(ref int IntVal);

//    class MyClass
//    {
//        int IntValue = 5;
//        public int Add2()
//        {
//            IntValue += 2;
//            return IntValue;
//        }
//        public int Add3()
//        {
//            IntValue += 3;
//            return IntValue;
//        }
//    }
//    class MyClass2
//    {
//        public int Add2(ref int IntValue)
//        {
//            IntValue += 2;
//            return IntValue;
//        }
//        public int Add3(ref int IntValue)
//        {
//            IntValue += 3;
//            return IntValue;
//        }
//    }
//    class Ch13Ex03
//    {
//        static void Main()
//        {
//            MyClass c = new MyClass();
//            MyDel mDel = new MyDel(c.Add2);
//            mDel += c.Add3;
//            mDel += c.Add2;

//            Console.WriteLine(mDel());
//            Console.WriteLine("*****************************");

//            MyClass2 c2 = new MyClass2();
//            MyDel2 mDel2 = new MyDel2(c2.Add2);
//            int x = 5;
//            Console.WriteLine(mDel2(ref x));
//            Console.WriteLine(x);
//            Console.ReadKey();
//        }
//    }
//}