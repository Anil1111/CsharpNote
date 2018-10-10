//using System;

//namespace Book
//{
//    class SomeClass
//    {
//        private int MyInt = 5;
//        virtual public int myInt
//        {
//            get
//            {
//                return MyInt;
//            }
//        }
//    }

//    class OtherClass: SomeClass
//    {
//        private int MyInt = 10;
//        override public int myInt
//        {
//            get
//            {
//                return MyInt;
//            }
//        }
//    }

//    class FinalClass : OtherClass
//    {
//        private int MyInt = 15;
//        new public int myInt
//        {
//            get
//            {
//                return MyInt;
//            }
//        }
//    }

//    class Ch07Ex01
//    {
//        static void Main(string[] args)
//        {
//            FinalClass oc = new FinalClass();
//            SomeClass sc = (OtherClass)oc;
//            Console.WriteLine(oc.myInt);
//            Console.WriteLine(sc.myInt);

//            Console.ReadKey();
//        }
//    }
//}